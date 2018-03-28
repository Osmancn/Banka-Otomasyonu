namespace WindowsFormsApp6
{
    partial class frmMusteriListe
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
            this.grdMusteriListesi = new System.Windows.Forms.DataGridView();
            this.btnListele = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriListesi)).BeginInit();
            this.SuspendLayout();
            // 
            // grdMusteriListesi
            // 
            this.grdMusteriListesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMusteriListesi.Location = new System.Drawing.Point(9, 10);
            this.grdMusteriListesi.Margin = new System.Windows.Forms.Padding(2);
            this.grdMusteriListesi.Name = "grdMusteriListesi";
            this.grdMusteriListesi.RowTemplate.Height = 24;
            this.grdMusteriListesi.Size = new System.Drawing.Size(477, 231);
            this.grdMusteriListesi.TabIndex = 0;
            this.grdMusteriListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(344, 280);
            this.btnListele.Margin = new System.Windows.Forms.Padding(2);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(142, 42);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Müşteri Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // frmMusteriListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 332);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.grdMusteriListesi);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMusteriListe";
            this.Text = "Müşteri Listesi";
            this.Load += new System.EventHandler(this.frmMusteriListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMusteriListesi;
        private System.Windows.Forms.Button btnListele;
    }
}