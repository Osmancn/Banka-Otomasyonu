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
    public partial class frmParaYatir : Form
    {
        public frmParaYatir()
        {
            InitializeComponent();
        }

        public Banka BankaApp;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte müsteriIndex = BankaApp.MüsteriIndexBul(Convert.ToInt32(cmbMüsteri.Text));
            foreach (Hesap h in BankaApp.müsteriList[müsteriIndex].hesapList)
            {
                cmbHesap.Items.Add(h.hesapNo);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cmbHesap==null || cmbMüsteri==null ||
                txtYatirilacakTutar==null || Convert.ToDecimal(txtYatirilacakTutar.Text)<=0)
            {
                MessageBox.Show("Lütfen Bilgileri Doğru Girdiğinizden Emin Olunuz");
            }
            else
            {
                byte müsteriIndex = BankaApp.MüsteriIndexBul(Convert.ToInt32(cmbMüsteri.Text));
                byte hesapIndex = BankaApp.müsteriList[müsteriIndex].
                    HesapIndexBul(Convert.ToInt32(cmbHesap.Text));

                BankaApp.müsteriList[müsteriIndex].hesapList[hesapIndex].
                    ParaEkle(Convert.ToDecimal(txtYatirilacakTutar.Text));

                MessageBox.Show(""+cmbHesap.Text+" numaralı hesaba "+txtYatirilacakTutar.Text+
                    " tl yatırıldı.");
            }
        }

        private void frmParaYatir_Load(object sender, EventArgs e)
        {
            foreach (Müsteri m in BankaApp.müsteriList)
            {
                cmbMüsteri.Items.Add(m.müsteriNo);
            }
        }
    }
}
