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
    public partial class frmHesapOzeti : Form
    {
        public frmHesapOzeti()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Banka BankaApp { get; set; }

        private void cmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte müsteriIndex = BankaApp.MüsteriIndexBul(Convert.ToInt32(cmbMusteri.Text));

            foreach (Hesap h in BankaApp.müsteriList[müsteriIndex].hesapList)
            {
                cmbHesap.Items.Add(h.hesapNo);
            }
        }

        private void cmbHesap_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOzetle_Click(object sender, EventArgs e)
        {
            if(cmbHesap == null || cmbMusteri == null)
                MessageBox.Show("Lütfen Bilgileri Seçtiğinizden Emin Olunuz...");
            else
            {
                byte müsteriIndex = BankaApp.MüsteriIndexBul(Convert.ToInt32(cmbMusteri.Text));

                byte hesapIndex = BankaApp.müsteriList[müsteriIndex].
                    HesapIndexBul(Convert.ToInt32(cmbHesap.Text));

                dataGridView1.DataSource = null;

                dataGridView1.DataSource= BankaApp.müsteriList[müsteriIndex].
                    hesapList[hesapIndex].hesapozeti;
            }
        }

        private void frmHesapOzeti_Load(object sender, EventArgs e)
        {
            foreach (Müsteri m in BankaApp.müsteriList)
            {
                cmbMusteri.Items.Add(m.müsteriNo);
            }
        }
    }
}
