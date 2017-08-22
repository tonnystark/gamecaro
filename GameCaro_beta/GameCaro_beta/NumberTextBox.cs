using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro_beta
{
    public partial class NumberTextBox : TextBox
    {
        public NumberTextBox()
        {
            InitializeComponent();
            this.KeyPress += NumberTextBox_KeyPress;
        }

        private void NumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
