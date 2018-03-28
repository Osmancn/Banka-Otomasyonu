namespace WindowsFormsApp6
{
    partial class frmHesapKapat
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
            this.btnHesapKapat = new System.Windows.Forms.Button();
            this.cmbMüsteri = new System.Windows.Forms.ComboBox();
            this.cmbHesap = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesabı Kapatılacak Müşteri No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kapatılacak Hesap No:";
            // 
            // btnHesapKapat
            // 
            this.btnHesapKapat.Location = new System.Drawing.Point(224, 69);
            this.btnHesapKapat.Margin = new System.Windows.Forms.Padding(2);
            this.btnHesapKapat.Name = "btnHesapKapat";
            this.btnHesapKapat.Size = new System.Drawing.Size(92, 23);
            this.btnHesapKapat.TabIndex = 2;
            this.btnHesapKapat.Text = "Hesabı Kapat";
            this.btnHesapKapat.UseVisualStyleBackColor = true;
            this.btnHesapKapat.Click += new System.EventHandler(this.btnHesapKapat_Click);
            // 
            // cmbMüsteri
            // 
            this.cmbMüsteri.FormattingEnabled = true;
            this.cmbMüsteri.Location = new System.Drawing.Point(181, 19);
            this.cmbMüsteri.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMüsteri.Name = "cmbMüsteri";
            this.cmbMüsteri.Size = new System.Drawing.Size(136, 21);
            this.cmbMüsteri.TabIndex = 3;
            this.cmbMüsteri.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbHesap
            // 
            this.cmbHesap.FormattingEnabled = true;
            this.cmbHesap.Location = new System.Drawing.Point(181, 45);
            this.cmbHesap.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHesap.Name = "cmbHesap";
            this.cmbHesap.Size = new System.Drawing.Size(136, 21);
            this.cmbHesap.TabIndex = 4;
            this.cmbHesap.SelectedIndexChanged += new System.EventHandler(this.cmbHesap_SelectedIndexChanged);
            // 
            // frmHesapKapat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 102);
            this.Controls.Add(this.cmbHesap);
            this.Controls.Add(this.cmbMüsteri);
            this.Controls.Add(this.btnHesapKapat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHesapKapat";
            this.Text = "Hesap Kapat";
            this.Load += new System.EventHandler(this.frmHesapKapat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHesapKapat;
        private System.Windows.Forms.ComboBox cmbMüsteri;
        private System.Windows.Forms.ComboBox cmbHesap;
    }
}