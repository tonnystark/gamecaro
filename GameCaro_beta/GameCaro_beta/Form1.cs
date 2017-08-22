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
        private ChessManager chess;

        public Form1()
        {
            InitializeComponent();
            chess = new ChessManager(pnlCaro);
            chess.DrawBoard();
        }



        private void btnOk_Click(object sender, EventArgs e)
        {
            int row = 0;
            if (txtNumber.Text != "")
                row = int.Parse(txtNumber.Text);
            pnlCaro.Controls.Clear();

            chess = new ChessManager(pnlCaro);
            chess.DrawBoard(row);
        }
    }
}
