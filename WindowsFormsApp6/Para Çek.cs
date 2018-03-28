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
    public partial class frmParaCek : Form
    {
        public frmParaCek()
        {
            InitializeComponent();
        }

        public Banka BankaApp;

        private void cmbMüsteri_SelectedIndexChanged(object sender, EventArgs e)
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

        private void btnParaCek_Click(object sender, EventArgs e)
        {
            byte müsteriIndex = BankaApp.MüsteriIndexBul(Convert.ToInt32(cmbMüsteri.Text));

            if (cmbHesap==null || cmbMüsteri==null || txtCekilecekTutar==null 
                || Convert.ToDecimal(txtCekilecekTutar.Text)<=0)
            {
                MessageBox.Show("Lütfen Bilgileri Doğru Girdiğinizden Emin Olunuz...");
            }

            else if(Convert.ToDecimal(txtCekilecekTutar.Text)>
                BankaApp.müsteriList[müsteriIndex].MüsteriToplamParası())
                MessageBox.Show("Yetersiz bakiye");

            else if(Convert.ToDecimal(txtCekilecekTutar)>
                BankaApp.müsteriList[müsteriIndex].kalanLimit)
                MessageBox.Show("Günlük limiti aştınız."+ 
                    BankaApp.müsteriList[müsteriIndex].kalanLimit+
                    "tl limitiniz kalmıştır");

            else
            {
               
                byte hesapIndex = BankaApp.müsteriList[müsteriIndex].
                    HesapIndexBul(Convert.ToInt32(cmbHesap.Text));

                BankaApp.müsteriList[müsteriIndex].
                    HesaptanParaCekme(BankaApp.müsteriList[müsteriIndex].hesapList[hesapIndex],
                    Convert.ToDecimal(txtCekilecekTutar.Text));

                MessageBox.Show(""+cmbHesap.Text+" numaralı hesaptan"+txtCekilecekTutar.Text+
                    " tl çekişlmiştir");
            }
        }

        private void frmParaCek_Load(object sender, EventArgs e)
        {
            foreach (Müsteri m in BankaApp.müsteriList)
            {
                cmbMüsteri.Items.Add(m.müsteriNo);
            }
        }
    }
}
