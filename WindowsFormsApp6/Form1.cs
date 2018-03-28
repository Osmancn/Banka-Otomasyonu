using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        Banka BankaApp = new Banka();
        
        private void müşteriEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frmMusteriEkleme = new frmMusteriEkle();
            frmMusteriEkleme.MdiParent = this;
            frmMusteriEkleme.BankaApp = this.BankaApp;
            frmMusteriEkleme.Show();
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMusteriListe frmMusteriListesi = new frmMusteriListe();
            frmMusteriListesi.MdiParent = this;
            frmMusteriListesi.BankaApp = this.BankaApp;
            frmMusteriListesi.Show();
        }

        private void hesapAçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapAc frmHesapAcma = new frmHesapAc();
            frmHesapAcma.MdiParent = this;
            frmHesapAcma.BankaApp = this.BankaApp;
            frmHesapAcma.Show();
        }

        private void hesapKapamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapKapat frmHesapKapatma = new frmHesapKapat();
            frmHesapKapatma.MdiParent = this;
            frmHesapKapatma.BankaApp = this.BankaApp;
            frmHesapKapatma.Show();
        }

        private void paraÇekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParaCek frmParaCekme = new frmParaCek();
            frmParaCekme.MdiParent = this;
            frmParaCekme.BankaApp = BankaApp;
            frmParaCekme.Show();
        }

        private void paraYatırToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmParaYatir frmParaYatırma = new frmParaYatir();
            frmParaYatırma.MdiParent = this;
            frmParaYatırma.BankaApp = this.BankaApp;
            frmParaYatırma.Show();
        }

        private void havaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHavale frmHavaleYap = new frmHavale();
            frmHavaleYap.MdiParent = this;
            frmHavaleYap.BankaApp = this.BankaApp;
            frmHavaleYap.Show();
        }

        private void gelirGiderÖzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGelirGiderOzt frmGelirGiderOzeti = new frmGelirGiderOzt();
            frmGelirGiderOzeti.MdiParent = this;
            frmGelirGiderOzeti.BankaApp = this.BankaApp;
            frmGelirGiderOzeti.Show();
        }

        private void hesapOzetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHesapOzeti frmHesapOzet = new frmHesapOzeti();
            frmHesapOzet.MdiParent = this;
            frmHesapOzet.BankaApp = this.BankaApp;
            frmHesapOzet.Show();
        }
    }
}
