namespace WindowsFormsApp6
{
    partial class frmHavale
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbGonderen = new System.Windows.Forms.ComboBox();
            this.cmbAlici = new System.Windows.Forms.ComboBox();
            this.txthavale = new System.Windows.Forms.TextBox();
            this.btnHavaleYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gönderen Hesap:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Alıcı Hesap:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tutar:";
            // 
            // cmbGonderen
            // 
            this.cmbGonderen.FormattingEnabled = true;
            this.cmbGonderen.Location = new System.Drawing.Point(112, 21);
            this.cmbGonderen.Margin = new System.Windows.Forms.Padding(2);
            this.cmbGonderen.Name = "cmbGonderen";
            this.cmbGonderen.Size = new System.Drawing.Size(92, 21);
            this.cmbGonderen.TabIndex = 3;
            this.cmbGonderen.SelectedIndexChanged += new System.EventHandler(this.cmbGonderen_SelectedIndexChanged);
            // 
            // cmbAlici
            // 
            this.cmbAlici.FormattingEnabled = true;
            this.cmbAlici.Location = new System.Drawing.Point(112, 43);
            this.cmbAlici.Margin = new System.Windows.Forms.Padding(2);
            this.cmbAlici.Name = "cmbAlici";
            this.cmbAlici.Size = new System.Drawing.Size(92, 21);
            this.cmbAlici.TabIndex = 4;
            this.cmbAlici.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // txthavale
            // 
            this.txthavale.Location = new System.Drawing.Point(112, 67);
            this.txthavale.Margin = new System.Windows.Forms.Padding(2);
            this.txthavale.Name = "txthavale";
            this.txthavale.Size = new System.Drawing.Size(92, 20);
            this.txthavale.TabIndex = 5;
            this.txthavale.TextChanged += new System.EventHandler(this.txthavale_TextChanged);
            // 
            // btnHavaleYap
            // 
            this.btnHavaleYap.Location = new System.Drawing.Point(135, 98);
            this.btnHavaleYap.Margin = new System.Windows.Forms.Padding(2);
            this.btnHavaleYap.Name = "btnHavaleYap";
            this.btnHavaleYap.Size = new System.Drawing.Size(68, 28);
            this.btnHavaleYap.TabIndex = 6;
            this.btnHavaleYap.Text = "Havale Yap";
            this.btnHavaleYap.UseVisualStyleBackColor = true;
            this.btnHavaleYap.Click += new System.EventHandler(this.btnHavaleYap_Click);
            // 
            // frmHavale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 140);
            this.Controls.Add(this.btnHavaleYap);
            this.Controls.Add(this.txthavale);
            this.Controls.Add(this.cmbAlici);
            this.Controls.Add(this.cmbGonderen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHavale";
            this.Text = "Havale";
            this.Load += new System.EventHandler(this.frmHavale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbGonderen;
        private System.Windows.Forms.ComboBox cmbAlici;
        private System.Windows.Forms.TextBox txthavale;
        private System.Windows.Forms.Button btnHavaleYap;
    }
}