using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaroDACS
{
    public class ChessBoardManager
    {


        #region Properties
        private Panel chessBoard;
        private List<Player> player;
        private int currentPlayer;
        private TextBox playerName;
        private PictureBox playerMark;
        private List<List<Button>> matrix;
        private Stack<Point> luuDiemDanh;

        public Panel ChessBoard { get => chessBoard; set => chessBoard = value; }
        public List<Player> Player { get => player; set => player = value; }
        public int CurrentPlayer { get => currentPlayer; set => currentPlayer = value; }
        public List<List<Button>> Matrix { get => matrix; set => matrix = value; }
        public TextBox PlayerName { get => playerName; set => playerName = value; }
        public PictureBox PlayerMark { get => playerMark; set => playerMark = value; }
        public Stack<Point> LuuDiemDanh { get => luuDiemDanh; set => luuDiemDanh = value; }

        private event EventHandler<ButtonEvent> playerMarked;
        public event EventHandler<ButtonEvent> PlayMarked
        {
            add
            {
                playerMarked += value;
            }
            remove
            {
                playerMarked -= value;
            }
        }

        private event EventHandler endedGame;
        public event EventHandler EndedGame
        {
            add
            {
                endedGame += value;
            }
            remove
            {
                endedGame -= value;
            }
        }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel panelChess, TextBox playerName, PictureBox mark)
        {
            this.ChessBoard = panelChess;
            this.PlayerName = playerName;
            this.PlayerMark = mark;
            this.Player = new List<Player>()
         {

        new Player("Player1", Image.FromFile(Application.StartupPath + "\\Resources\\o.png")),
        new Player("Player2", Image.FromFile(Application.StartupPath + "\\Resources\\x.png")),

         };
           
            LuuDiemDanh = new Stack<Point>();
        }
            #endregion
            #region Methods
            public void DrawChessBoard()
            {
            ChessBoard.Enabled = true;
            ChessBoard.Controls.Clear(); 
            CurrentPlayer = 0;
            ChangePlayer();

            Matrix = new List<List<Button>>();


                Button oldButton = new Button() { Width = 0, Location = new Point(0, 0) }; //Ve ban co
                for (int i = 0; i < GiaTri.ChessBoardHeight; i++)
                {
                    Matrix.Add(new List<Button>());

                    for (int j = 0; j < GiaTri.ChessBoardWidth; j++)
                    {
                        Button btn = new Button()
                        {
                            Width = GiaTri.ChessWidth,
                            Height = GiaTri.ChessHeight, // Kich thuoc button
                            Location = new Point(oldButton.Location.X + oldButton.Width, oldButton.Location.Y), // toa do cac button
                            BackgroundImageLayout = ImageLayout.Stretch,
                            Tag = i.ToString() // Luu thuoc tinh de biet vi tri button
                        };
                        btn.Click += BtnClick;

                        ChessBoard.Controls.Add(btn);

                        Matrix[i].Add(btn);

                        oldButton = btn;
                    }
                    oldButton.Location = new Point(0, oldButton.Location.Y + GiaTri.ChessHeight);
                    oldButton.Width = 0;
                    oldButton.Height = 0;
                }
            }
            
            
            public void Mark(Button btn) //thay doi ki hieu x/o 
            {
                btn.BackgroundImage = Player[CurrentPlayer].Mark;
                CurrentPlayer = CurrentPlayer == 1 ? 0 : 1; //doi luot nguoi choi
            }
            private void ChangePlayer() //thay doi player
            {
                PlayerName.Text = Player[CurrentPlayer].Name;
                PlayerMark.Image = Player[CurrentPlayer].Mark;
            }

            public void BtnClick(object sender, EventArgs e)
            {
                Button btn = sender as Button; //ep kieu lai sender

                if (btn.BackgroundImage != null) //o da co hinh ko the dien
                    return;

                Mark(btn);

                LuuDiemDanh.Push(GetChessPoint(btn));

                ChangePlayer();

                if (playerMarked != null)
                    playerMarked(this, new ButtonEvent(GetChessPoint(btn)));

                if (winGame(btn))
                {
                EndGame();
                }
            }
        public void nguoikhacdanh(Point point)
        {
            Button btn = Matrix[point.Y][point.X];

            if (btn.BackgroundImage != null) //o da co hinh ko the dien
                return;
            ChessBoard.Enabled = true;
            Mark(btn);

            LuuDiemDanh.Push(GetChessPoint(btn));

            ChangePlayer();

            if (winGame(btn))
            {
                EndGame();
            }
        }

        public void EndGame()
            { 
            //DialogResult result = MessageBox.Show("Bạn đã chiến thắng !!!!","Thông báo");
            if (endedGame != null)
                endedGame(this, new EventArgs());
            ChessBoard.Enabled = false;
            }
            public bool winGame(Button btn)
            {
                return winHorizontal(btn) || winVertical(btn) || winPrimary(btn) || winSub(btn); 
            }


        private Point GetChessPoint(Button btn)
        {
            int vertical = Convert.ToInt32(btn.Tag);
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }
        private bool winHorizontal(Button btn) // win hang ngang
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }
            int countRight = 0;
            for (int i = point.X + 1; i < GiaTri.ChessBoardWidth; i++)
            {
                if (Matrix[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight == 5;
           
        }

            private bool winVertical(Button btn) // win hang doc
            {
                Point point = GetChessPoint(btn);

                int countTop = 0;
                for (int i = point.Y; i >= 0; i--)
                {
                    if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    {
                        countTop++;
                    }
                    else
                        break;
                }
                int countBottom = 0;
                for (int i = point.Y + 1; i < GiaTri.ChessBoardHeight; i++)
                {
                    if (Matrix[i][point.X].BackgroundImage == btn.BackgroundImage)
                    {
                        countBottom++;
                    }
                    else
                        break;
                }

                return countTop + countBottom == 5;
            }
            private bool winPrimary(Button btn) // win duong cheo chinh
            {
                Point point = GetChessPoint(btn);

                int countTop = 0;
                for (int i = 0; i <= point.X; i++)
                {
                    if (point.X - i < 0 || point.Y - i < 0)
                        break;
                    if (Matrix[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    {
                        countTop++;
                    }
                    else
                        break;
                }
                int countBottom = 0;
                for (int i = 1; i < GiaTri.ChessBoardWidth - point.X; i++)
                {
                    if (point.Y + i >= GiaTri.ChessBoardHeight || point.X + i >= GiaTri.ChessBoardWidth)
                        break;
                    if (Matrix[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    {
                        countBottom++;
                    }
                    else
                        break;
                }

                return countTop + countBottom == 5;
            }
            private bool winSub(Button btn) // win duong cheo phu
            {
                Point point = GetChessPoint(btn);

                int countTop = 0;
                for (int i = 0; i <= point.X; i++)
                {
                    if (point.X + i > GiaTri.ChessBoardWidth || point.Y - i < 0)
                        break;
                    if (Matrix[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                    {
                        countTop++;
                    }
                    else
                        break;
                }
                int countBottom = 0;
                for (int i = 1; i <= GiaTri.ChessBoardWidth - point.X; i++)
                {
                    if (point.Y + i >= GiaTri.ChessBoardHeight || point.X + i < 0)
                        break;
                    if (Matrix[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                    {
                        countBottom++;
                    }
                    else
                        break;
                }

                return countTop + countBottom == 5;
            }
        #endregion
       
        public bool Undo()
        {
            Point oldpoint = LuuDiemDanh.Pop();
            Button btn = Matrix[oldpoint.Y][oldpoint.X];

            btn.BackgroundImage = null;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            ChangePlayer();
            return true;
        }

        public bool Redo()
        {
            Point oldpoint = LuuDiemDanh.Pop();
            Button btn = Matrix[oldpoint.Y][oldpoint.X];

            btn.BackgroundImage = null;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;

            ChangePlayer();
            return true;
        }
        public class ButtonEvent : EventArgs
        {
            private Point clickedPoint;
            public Point ClickedPoint { get => clickedPoint; set => clickedPoint = value; }
            public ButtonEvent(Point point)
            {
                this.ClickedPoint = point;
            }
        }
    }

}
