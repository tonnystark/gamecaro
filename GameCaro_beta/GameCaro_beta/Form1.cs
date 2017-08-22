using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro_beta
{
    public partial class Form1 : Form
    {
        public const int C_WIDTH = 30;
        public const int C_HEIGHT = 30;
        public const int C_ROW = 17;

        public Form1()
        {
            InitializeComponent();
            DrawBoard();
        }

        public void DrawBoard(int row = C_ROW)
        {
            Button btn0 = new Button() { Width = 0, Height = 0, Location = new Point(0, 0) };
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j <= row; j++)
                {
                    Button btn = new Button()
                    {
                        Width = C_WIDTH,
                        Height = C_HEIGHT,
                        Location = new Point(btn0.Location.X + btn0.Width, btn0.Location.Y)
                    };
                    pnlCaro.Controls.Add(btn);
                    btn0 = btn;
                }
                btn0.Location = new Point(0, btn0.Location.Y + C_HEIGHT);
                btn0.Width = 0;
                btn0.Height = 0;
            }




        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int row = 0;
            if (txtNumber.Text != "")
                row = int.Parse(txtNumber.Text);
            pnlCaro.Controls.Clear();

            DrawBoard(row);
        }
    }
}
