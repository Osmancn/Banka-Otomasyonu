namespace WindowsFormsApp6
{
    partial class frmParaCek
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
            this.txtCekilecekTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.cmbHesap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMüsteri = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCekilecekTutar
            // 
            this.txtCekilecekTutar.Location = new System.Drawing.Point(125, 72);
            this.txtCekilecekTutar.Margin = new System.Windows.Forms.Padding(2);
            this.txtCekilecekTutar.Name = "txtCekilecekTutar";
            this.txtCekilecekTutar.Size = new System.Drawing.Size(130, 20);
            this.txtCekilecekTutar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Çekilecek Hesap No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Çekilecek Tutar:";
            // 
            // btnParaCek
            // 
            this.btnParaCek.Location = new System.Drawing.Point(144, 96);
            this.btnParaCek.Margin = new System.Windows.Forms.Padding(2);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(88, 32);
            this.btnParaCek.TabIndex = 4;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = true;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // cmbHesap
            // 
            this.cmbHesap.FormattingEnabled = true;
            this.cmbHesap.Location = new System.Drawing.Point(125, 47);
            this.cmbHesap.Margin = new System.Windows.Forms.Padding(2);
            this.cmbHesap.Name = "cmbHesap";
            this.cmbHesap.Size = new System.Drawing.Size(130, 21);
            this.cmbHesap.TabIndex = 5;
            this.cmbHesap.SelectedIndexChanged += new System.EventHandler(this.cmbHesap_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Çekilecek Müşteri No:";
            // 
            // cmbMüsteri
            // 
            this.cmbMüsteri.FormattingEnabled = true;
            this.cmbMüsteri.Location = new System.Drawing.Point(125, 20);
            this.cmbMüsteri.Name = "cmbMüsteri";
            this.cmbMüsteri.Size = new System.Drawing.Size(130, 21);
            this.cmbMüsteri.TabIndex = 7;
            this.cmbMüsteri.SelectedIndexChanged += new System.EventHandler(this.cmbMüsteri_SelectedIndexChanged);
            // 
            // frmParaCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 136);
            this.Controls.Add(this.cmbMüsteri);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbHesap);
            this.Controls.Add(this.btnParaCek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCekilecekTutar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmParaCek";
            this.Text = "Para Çek";
            this.Load += new System.EventHandler(this.frmParaCek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCekilecekTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnParaCek;
        private System.Windows.Forms.ComboBox cmbHesap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMüsteri;
    }
}