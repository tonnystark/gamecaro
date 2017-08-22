namespace GameCaro_beta
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlCaro = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtNumber = new GameCaro_beta.NumberTextBox();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCaro
            // 
            this.pnlCaro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlCaro.Location = new System.Drawing.Point(12, 12);
            this.pnlCaro.Name = "pnlCaro";
            this.pnlCaro.Size = new System.Drawing.Size(600, 600);
            this.pnlCaro.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(621, 15);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(358, 365);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 285);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(358, 226);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel4.Controls.Add(this.btnOk);
            this.panel4.Controls.Add(this.txtNumber);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(621, 386);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(355, 226);
            this.panel4.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 285);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(358, 226);
            this.panel5.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "XIN VUI LÒNG NHẬP SỐ DÒNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Số dòng";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(120, 91);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(89, 28);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(75, 63);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(175, 22);
            this.txtNumber.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 619);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlCaro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Game Caro";
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCaro;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private NumberTextBox txtNumber;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label2;
    }
}

