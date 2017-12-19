namespace WindowsFormsApp6
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bankaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEklemeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGiderÖzetiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapKapamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraÇekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraYatırToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankaİşlemleriToolStripMenuItem,
            this.müşteriİşlemleriToolStripMenuItem,
            this.hesapİşlemleriToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(875, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bankaİşlemleriToolStripMenuItem
            // 
            this.bankaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEklemeToolStripMenuItem,
            this.müşteriListesiToolStripMenuItem,
            this.gelirGiderÖzetiToolStripMenuItem});
            this.bankaİşlemleriToolStripMenuItem.Name = "bankaİşlemleriToolStripMenuItem";
            this.bankaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.bankaİşlemleriToolStripMenuItem.Text = "Banka İşlemleri";
            // 
            // müşteriEklemeToolStripMenuItem
            // 
            this.müşteriEklemeToolStripMenuItem.Name = "müşteriEklemeToolStripMenuItem";
            this.müşteriEklemeToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.müşteriEklemeToolStripMenuItem.Text = "Müşteri Ekleme";
            this.müşteriEklemeToolStripMenuItem.Click += new System.EventHandler(this.müşteriEklemeToolStripMenuItem_Click);
            // 
            // müşteriListesiToolStripMenuItem
            // 
            this.müşteriListesiToolStripMenuItem.Name = "müşteriListesiToolStripMenuItem";
            this.müşteriListesiToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.müşteriListesiToolStripMenuItem.Text = "Müşteri Listesi";
            this.müşteriListesiToolStripMenuItem.Click += new System.EventHandler(this.müşteriListesiToolStripMenuItem_Click);
            // 
            // gelirGiderÖzetiToolStripMenuItem
            // 
            this.gelirGiderÖzetiToolStripMenuItem.Name = "gelirGiderÖzetiToolStripMenuItem";
            this.gelirGiderÖzetiToolStripMenuItem.Size = new System.Drawing.Size(196, 26);
            this.gelirGiderÖzetiToolStripMenuItem.Text = "Gelir-Gider Özeti";
            // 
            // müşteriİşlemleriToolStripMenuItem
            // 
            this.müşteriİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapAçToolStripMenuItem,
            this.hesapKapamaToolStripMenuItem});
            this.müşteriİşlemleriToolStripMenuItem.Name = "müşteriİşlemleriToolStripMenuItem";
            this.müşteriİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.müşteriİşlemleriToolStripMenuItem.Text = "Müşteri İşlemleri";
            // 
            // hesapAçToolStripMenuItem
            // 
            this.hesapAçToolStripMenuItem.Name = "hesapAçToolStripMenuItem";
            this.hesapAçToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.hesapAçToolStripMenuItem.Text = "Hesap Açma";
            this.hesapAçToolStripMenuItem.Click += new System.EventHandler(this.hesapAçToolStripMenuItem_Click);
            // 
            // hesapKapamaToolStripMenuItem
            // 
            this.hesapKapamaToolStripMenuItem.Name = "hesapKapamaToolStripMenuItem";
            this.hesapKapamaToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.hesapKapamaToolStripMenuItem.Text = "Hesap Kapama";
            this.hesapKapamaToolStripMenuItem.Click += new System.EventHandler(this.hesapKapamaToolStripMenuItem_Click);
            // 
            // hesapİşlemleriToolStripMenuItem
            // 
            this.hesapİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraÇekToolStripMenuItem,
            this.paraYatırToolStripMenuItem,
            this.havaleToolStripMenuItem});
            this.hesapİşlemleriToolStripMenuItem.Name = "hesapİşlemleriToolStripMenuItem";
            this.hesapİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.hesapİşlemleriToolStripMenuItem.Text = "Hesap İşlemleri";
            // 
            // paraÇekToolStripMenuItem
            // 
            this.paraÇekToolStripMenuItem.Name = "paraÇekToolStripMenuItem";
            this.paraÇekToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.paraÇekToolStripMenuItem.Text = "Para Çek";
            this.paraÇekToolStripMenuItem.Click += new System.EventHandler(this.paraÇekToolStripMenuItem_Click);
            // 
            // paraYatırToolStripMenuItem
            // 
            this.paraYatırToolStripMenuItem.Name = "paraYatırToolStripMenuItem";
            this.paraYatırToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.paraYatırToolStripMenuItem.Text = "Para Yatır";
            this.paraYatırToolStripMenuItem.Click += new System.EventHandler(this.paraYatırToolStripMenuItem_Click);
            // 
            // havaleToolStripMenuItem
            // 
            this.havaleToolStripMenuItem.Name = "havaleToolStripMenuItem";
            this.havaleToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.havaleToolStripMenuItem.Text = "Havale";
            this.havaleToolStripMenuItem.Click += new System.EventHandler(this.havaleToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.yardımToolStripMenuItem.Text = "yardım";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(875, 443);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Banka Otomasyonu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bankaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEklemeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderÖzetiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapKapamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraÇekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraYatırToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
    }
}

