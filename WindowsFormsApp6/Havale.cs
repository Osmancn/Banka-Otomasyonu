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
    public partial class frmHavale : Form
    {
        public frmHavale()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Banka BankaApp;

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbGonderen_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txthavale_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHavaleYap_Click(object sender, EventArgs e)
        {
            if (cmbGonderen == null || cmbAlici == null || txthavale == null
                || Convert.ToInt32(txthavale.Text) <= 0)
            {
                MessageBox.Show("Bilgileri Tekrar Kontrol Ediniz");
            }

            else
            {
                byte gMusteriIndex = BankaApp.MüsteriIndexBulH(Convert.ToInt32(cmbGonderen.Text));
                byte gHesapIndex = BankaApp.müsteriList[gMusteriIndex].
                    HesapIndexBul(Convert.ToInt32(cmbGonderen.Text));

                byte aMusteriIndex = BankaApp.MüsteriIndexBulH(Convert.ToInt32(cmbAlici.Text));
                byte aHesapIndex = BankaApp.müsteriList[aMusteriIndex].
                    HesapIndexBul(Convert.ToInt32(cmbAlici.Text));

                BankaApp.Havale(BankaApp.müsteriList[gMusteriIndex].hesapList[gHesapIndex],
                    BankaApp.müsteriList[aMusteriIndex].hesapList[aHesapIndex],
                    Convert.ToInt32(txthavale.Text));

                MessageBox.Show(""+cmbGonderen.Text+"numaralı hesaptan "+cmbAlici.Text+
                    "numaralı hesaba"+txthavale.Text +"tl havale yapılmıştır");
            }
        }

        private void frmHavale_Load(object sender, EventArgs e)
        {
            foreach (Müsteri m in BankaApp.müsteriList)
            {
                foreach (Hesap h in m.hesapList)
                {
                    cmbGonderen.Items.Add(h.hesapNo);
                }
            }

            foreach (Müsteri m in BankaApp.müsteriList)
            {
                foreach (Hesap h in m.hesapList)
                {
                    cmbAlici.Items.Add(h.hesapNo);
                }
            }
        }
    }
}
