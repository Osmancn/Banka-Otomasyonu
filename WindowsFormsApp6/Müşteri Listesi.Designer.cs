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
            this.grdMusteriListesi.Location = new System.Drawing.Point(12, 12);
            this.grdMusteriListesi.Name = "grdMusteriListesi";
            this.grdMusteriListesi.RowTemplate.Height = 24;
            this.grdMusteriListesi.Size = new System.Drawing.Size(636, 284);
            this.grdMusteriListesi.TabIndex = 0;
            this.grdMusteriListesi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(459, 344);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(189, 52);
            this.btnListele.TabIndex = 1;
            this.btnListele.Text = "Müşteri Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // frmMusteriListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 408);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.grdMusteriListesi);
            this.Name = "frmMusteriListe";
            this.Text = "Müşteri Listesi";
            ((System.ComponentModel.ISupportInitialize)(this.grdMusteriListesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdMusteriListesi;
        private System.Windows.Forms.Button btnListele;
    }
}