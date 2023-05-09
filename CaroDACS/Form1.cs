using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroDACS
{
    public partial class Form1 : Form
    {
        #region Properties
        ChessBoardManager ChessBoard;
        #endregion
        public Form1()
        {
            InitializeComponent();

            ChessBoard = new ChessBoardManager(panelChess, txbName, picLogo);
            ChessBoard.EndedGame += ChessBoard_EndedGame;
            ChessBoard.PlayMarked += ChessBoard_PlayerMarked;

            prcbTime.Step = GiaTri.CoolDownStep;
            prcbTime.Maximum = GiaTri.CoolDownTime;
            prcbTime.Value = 0;

            tmCoolDown.Interval = GiaTri.CoolDownInterval;
            //tmCoolDown.Start();

            ChessBoard.DrawChessBoard();
        }


        private void tmCoolDown_Tick(object sender, EventArgs e)
        {
            prcbTime.PerformStep();
            if (prcbTime.Value >= prcbTime.Maximum)
            {
                tmCoolDown.Stop();
                MessageBox.Show("Đã hết giờ, bạn đã thua !", "Thông báo", MessageBoxButtons.OK);
                ChessBoard.ChessBoard.Enabled = false;
            }
        }

        private void ChessBoard_PlayerMarked(object sender, EventArgs e)
        {
            tmCoolDown.Start();
            prcbTime.Value = 0;
        }
        private void ChessBoard_EndedGame(object sender, EventArgs e)
        {
            EndGame();
        }

        private void EndGame()
        {
            tmCoolDown.Stop();

        }

        private void txbTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            prcbTime.PerformStep();
            if (prcbTime.Value >= prcbTime.Maximum)
            {
                tmCoolDown.Stop();
                MessageBox.Show("Đã hết giờ, bạn đã thua !", "Thông báo", MessageBoxButtons.OK);
            }
        }



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Form2 fm2 = new Form2();
            fm2.Show();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            ChessBoard.Undo();
        }

        private void btnRedo_Click(object sender, EventArgs e)
        {
            ChessBoard.Redo();
        }

        private void btnnewgame_Click(object sender, EventArgs e)
        {
            prcbTime.Value = 0;
            tmCoolDown.Stop();
            ChessBoard.DrawChessBoard();
        }
    }
}
