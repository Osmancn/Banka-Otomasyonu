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
    public partial class frmHesapKapat : Form
    {
        public frmHesapKapat()
        {
            InitializeComponent();
        }
        public Banka BankaApp;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte müsteriIndex = BankaApp.MüsteriIndexBul(Convert.ToInt32(cmbMüsteri.Text));

            foreach (Hesap h in BankaApp.müsteriList[müsteriIndex].hesapList)
            {
                cmbHesap.Items.Add(h.hesapNo);
            }
        }

        private void cmbHesap_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHesapKapat_Click(object sender, EventArgs e)
        {            
            if (cmbHesap == null || cmbMüsteri == null)
                MessageBox.Show("Lütfen Seçtiğinizden Emin Olunuz...");
            else
            {
                byte müsteriIndex = BankaApp.MüsteriIndexBul(Convert.ToInt32(cmbMüsteri.Text));
                byte hesapIndex = BankaApp.müsteriList[müsteriIndex].HesapIndexBul(
                    Convert.ToInt32(cmbHesap.Text));
                BankaApp.müsteriList[müsteriIndex].HesapKapama(
                BankaApp.müsteriList[müsteriIndex].hesapList[hesapIndex]
                );

                MessageBox.Show(""+cmbMüsteri.Text+" numaralı müşterinin "+cmbHesap.Text+
                    "hesabı kapatılmıştır");
            }
        }

        private void frmHesapKapat_Load(object sender, EventArgs e)
        {
            foreach (Müsteri m in BankaApp.müsteriList)
            {
                cmbMüsteri.Items.Add(m.müsteriNo);
            }

        }
    }
}
