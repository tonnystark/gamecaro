using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro_beta
{
    public class ChessManager
    {
        public Panel _pnlCaro { get; set; }
        public int CurrentPlayer { get; set; }
        public List<Player> Players { get; set; }
        public TextBox PlayerName { get; set; }
        public PictureBox PlayerMark { get; set; }
        public List<List<CusButton>> Matrix { get; set; }
        public ChessManager(Panel pnlCaro)
        {
            _pnlCaro = pnlCaro;
            CurrentPlayer = 0;
            Players = new List<Player>()
            {
                new Player("P1", Image.FromFile(Application.StartupPath + "\\Resources\\p1.png")),
                new Player("P2", Image.FromFile(Application.StartupPath + "\\Resources\\p2.png"))
            };
        }

        public void DrawBoard(int row = 20)
        {
            Matrix = new List<List<CusButton>>();
            CusButton btn0 = new CusButton() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < row; i++)
            {
                // khởi tạo 
                Matrix.Add(new List<CusButton>());

                for (int j = 0; j <= row; j++)
                {
                    CusButton btn = new CusButton()
                    {
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Width = Common.C_WIDTH,
                        Height = Common.C_HEIGHT,
                        Location = new Point(btn0.Location.X + btn0.Width, btn0.Location.Y),
                        // index dọc
                        Index = i
                    };

                    btn.Click += btn_Click;
                    _pnlCaro.Controls.Add(btn);
                    btn0 = btn;
                    // Add btn to matrix
                    Matrix[i].Add(btn);

                }
                btn0.Location = new Point(0, btn0.Location.Y + Common.C_HEIGHT);
                btn0.Width = 0;
                btn0.Height = 0;
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            CusButton btn = sender as CusButton;

            if (btn.BackgroundImage != null)
                return;

            Mark(btn);
            if (isEndGame(btn))
            {
                MessageBox.Show("Người chơi " + Players[CurrentPlayer].Name + " thắng");
            }
        }

        Point GetPoint(CusButton btn)
        {
            // vị trí theo chiều dọc
            int vertical = btn.Index;
            // vị trí theo chiều ngang
            int horizontal = Matrix[vertical].IndexOf(btn);

            Point p = new Point(horizontal, vertical);
            return p;
        }
        bool isEndGame(CusButton btn)
        {
            return KiemTraCheoChinh(btn) || KiemTraDoc(btn) || KiemTraNgang(btn) || KiemTraCheoPhu(btn);
        }

        bool KiemTraCheoChinh(CusButton btn)
        {
            Point p = GetPoint(btn);
            int top = 0, bottom = 0;
            // đếm chéo lên trên
            for (int i = 0; i <= p.X; i++)
            {
                if (p.Y - i < 0 || p.X - i < 0) break;
                if (Matrix[p.Y - i][p.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    top++;
                }
                else
                {
                    break;
                }
            }
            // đếm xuống dưới + 1 do đã đếm X ở trên
            for (int i = 1; i <= Common.C_ROW - p.X; i++)
            {
                if (p.Y + i >= Common.C_ROW || p.X + i >= Common.C_ROW) break;
                if (Matrix[p.Y + i][p.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    bottom++;
                }
                else
                {
                    break;
                }
            }

            return top + bottom >= Common.C_MODE;
        }
        bool KiemTraDoc(CusButton btn)
        {
            Point p = GetPoint(btn);
            int top = 0, bottom = 0;
            // đếm lên trên
            for (int i = p.Y; i >= 0; i--)
            {
                if (Matrix[i][p.X].BackgroundImage == btn.BackgroundImage)
                {
                    top++;
                }
                else
                {
                    break;
                }
            }
            // đếm xuống dưới + 1 do đã đếm X ở trên
            for (int i = p.Y + 1; i < Common.C_ROW; i++)
            {
                if (Matrix[i][p.X].BackgroundImage == btn.BackgroundImage)
                {
                    bottom++;
                }
                else
                {
                    break;
                }
            }

            return top + bottom >= Common.C_MODE;
        }
        bool KiemTraNgang(CusButton btn)
        {
            Point p = GetPoint(btn);
            int left = 0, right = 0;
            // đếm qua trái
            for (int i = p.X; i >= 0; i--)
            {
                if (Matrix[p.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    left++;
                }
                else
                {
                    break;
                }
            }
            // đếm qua phải + 1 do đã đếm X ở trên
            for (int i = p.X + 1; i < Common.C_ROW; i++)
            {
                if (Matrix[p.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    right++;
                }
                else
                {
                    break;
                }
            }

            return left + right >= Common.C_MODE;
        }
        bool KiemTraCheoPhu(CusButton btn)
        {
            Point p = GetPoint(btn);
            int top = 0, bottom = 0;
            // đếm chéo phụ lên trên
            for (int i = 0; i <= p.X; i++)
            {
                if (p.X + i > Common.C_ROW || p.Y - i < 0) break;
                if (Matrix[p.Y - i][p.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    top++;
                }
                else
                {
                    break;
                }
            }
            // đếm xuống dưới + 1 do đã đếm X ở trên
            for (int i = 1; i <= Common.C_ROW - p.X; i++)
            {
                if (p.Y + i >= Common.C_ROW || p.X - i < 0) break;
                if (Matrix[p.Y + i][p.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    bottom++;
                }
                else
                {
                    break;
                }
            }

            return top + bottom >= Common.C_MODE;
        }

        private void Mark(CusButton btn)
        {
            btn.BackgroundImage = Players[CurrentPlayer].Mark;

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
        }
    }
}
