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

        public ChessManager(Panel pnlCaro )
        {
            _pnlCaro = pnlCaro;
        }

        public void DrawBoard(int row = 20)
        {
            Button btn0 = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= row; j++)
                {
                    Button btn = new Button()
                    {
                        Width = Common.C_WIDTH,
                        Height = Common.C_HEIGHT,
                        Location = new Point(btn0.Location.X + btn0.Width, btn0.Location.Y)
                    };
                    _pnlCaro.Controls.Add(btn);
                    btn0 = btn;
                }
                btn0.Location = new Point(0, btn0.Location.Y + Common.C_HEIGHT);
                btn0.Width = 0;
                btn0.Height = 0;
            }
        }
    }
}
