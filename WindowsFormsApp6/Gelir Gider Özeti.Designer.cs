namespace WindowsFormsApp6
{
    partial class frmGelirGiderOzt
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
            this.grdGelirGider = new System.Windows.Forms.DataGridView();
            this.btnGelirGider = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdGelirGider)).BeginInit();
            this.SuspendLayout();
            // 
            // grdGelirGider
            // 
            this.grdGelirGider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGelirGider.Location = new System.Drawing.Point(27, 55);
            this.grdGelirGider.Name = "grdGelirGider";
            this.grdGelirGider.Size = new System.Drawing.Size(348, 220);
            this.grdGelirGider.TabIndex = 0;
            // 
            // btnGelirGider
            // 
            this.btnGelirGider.Location = new System.Drawing.Point(27, 13);
            this.btnGelirGider.Name = "btnGelirGider";
            this.btnGelirGider.Size = new System.Drawing.Size(348, 23);
            this.btnGelirGider.TabIndex = 1;
            this.btnGelirGider.Text = "Gelir-Gider Özeti";
            this.btnGelirGider.UseVisualStyleBackColor = true;
            this.btnGelirGider.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmGelirGiderOzt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 293);
            this.Controls.Add(this.btnGelirGider);
            this.Controls.Add(this.grdGelirGider);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmGelirGiderOzt";
            this.Text = "Gelir Gider Özeti";
            ((System.ComponentModel.ISupportInitialize)(this.grdGelirGider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdGelirGider;
        private System.Windows.Forms.Button btnGelirGider;
    }
}