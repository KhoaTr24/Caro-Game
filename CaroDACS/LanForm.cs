using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CaroDACS.ChessBoardManager;

namespace CaroDACS
{
    public partial class LanForm : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;

        TCPManager tcp;
        #endregion
        public LanForm()
        {
            InitializeComponent();
            ChessBoard = new ChessBoardManager(panelChess, txbName, picLogo);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayMarked += ChessBoard_PlayerMarked;
            ChessBoard.ChessBoard.Enabled = false;
            
            

            tcp = new TCPManager();

            prcbTime.Step = GiaTri.CoolDownStep;
            prcbTime.Maximum = GiaTri.CoolDownTime;
            prcbTime.Value = 0;

            tmCoolDown2.Interval = GiaTri.CoolDownInterval;
            tmCoolDown2.Start();

            ChessBoard.DrawChessBoard();
        }


        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prcbTime.PerformStep();
            if (prcbTime.Value >= prcbTime.Maximum)
            {
                tmCoolDown2.Stop();
                MessageBox.Show("Đã hết giờ, bạn đã thua !", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private void ChessBoard_PlayerMarked(object sender, ButtonEvent e)
        {
            tmCoolDown2.Start();
            prcbTime.Value = 0;
            ChessBoard.ChessBoard.Enabled = false;
            tcp.Send(new TCPData((int)TCPDataCommand.SEND_POINT, "", e.ClickedPoint));
            Listen();
        }
        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void EndGame()
        {
            tmCoolDown2.Stop();
            tcp.Send(new TCPData((int)TCPDataCommand.END_GAMEP1, "", new Point()));
        }

        private void txbTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prcbTime.PerformStep();
            if (prcbTime.Value >= prcbTime.Maximum)
            {
                tmCoolDown2.Stop();
                MessageBox.Show("Đã hết giờ, bạn đã thua !", "Thông báo", MessageBoxButtons.OK);
                ChessBoard.ChessBoard.Enabled = false;
            }
        }

        private void btnHost_Click(object sender, EventArgs e)
        {
            tcp.IP = txbIP.Text;
            tcp.CreateServer();
            tcp.server = true;
            ChessBoard.ChessBoard.Enabled = true;

            Thread listenThread = new Thread(() =>
            {
                while (true)
                {
                    Thread.Sleep(100000);
                    try
                    {
                        TCPData data = (TCPData)tcp.Receive();
                        break;
                    }
                    catch
                    {
                        txbStatus.Text += "\nĐang chờ kết nối...";
                    }
                }  
            });
            listenThread.IsBackground = true;
            listenThread.Start();
            txbStatus.Text += "Đang Tạo Host, Host đang chạy....";
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            tcp.IP = txbIP.Text;
            if (tcp.ConnectServer())
            {
                Listen();
                txbStatus.Text += "Đã Kết nối thành công đến Host";
                ChessBoard.ChessBoard.Enabled = false;
                tcp.server = false;
                btnnewgame.Enabled = false;
                //tcp.Send(new TCPData((int)TCPDataCommand.THONGBAO,"Client đã kết nối"));
            }
            else
            {         
                txbStatus.Text += "Không kết nối được đến Host";
            }
        }

        void Listen()
        {
                Thread listenThread = new Thread(() =>
                {
                    try
                    {
                        TCPData data = (TCPData)tcp.Receive();
                        XulyDataTCP(data);
                    }
                    catch
                    {

                    }
                });
                listenThread.IsBackground = true;
                listenThread.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
                tcp.StopServer();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            ChessBoard.Undo();
        }

        private void LanForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form2 f2 = new Form2();
            f2.Show();
            tcp.Send(new TCPData((int)TCPDataCommand.EXIT, "", new Point()));
        }

        private void XulyDataTCP(TCPData data)
        {
            switch(data.Command)
            {
                case (int)TCPDataCommand.THONGBAO:
                    MessageBox.Show(data.Message1);
                    break;
                case (int)TCPDataCommand.SEND_POINT:
                    ChessBoard.nguoikhacdanh(data.Point);
                    prcbTime.Value = 0;
                    break;
                case (int)TCPDataCommand.UNDO:
                    break;
                case (int)TCPDataCommand.EXIT:
                    MessageBox.Show("Người chơi đã thoát!");
                    break;
                case (int)TCPDataCommand.END_GAMEP1:
                    MessageBox.Show("Bạn đã chiến thắng !");                                            
                    ChessBoard.ChessBoard.Enabled = false;
                    break;
                default:
                    break;
                case (int)TCPDataCommand.NEW_GAME:
                    break;
            }

            Listen();
        }

        private void btnnewgame_Click(object sender, EventArgs e)
        {
            ChessBoard.DrawChessBoard();
        }
    }
}
