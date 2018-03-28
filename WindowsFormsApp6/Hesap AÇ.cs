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
    public partial class frmHesapAc : Form
    {
        public Banka BankaApp { get; set; }

        public frmHesapAc()
        {
            InitializeComponent();

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnHesapAc_Click(object sender, EventArgs e)
        {            
            if (cmbMusteri.Text=="")
                MessageBox.Show("Lütfen bir müsteri numarası seçiniz...");
            else
            {
                byte müsteriIndex = BankaApp.MüsteriIndexBul(Convert.ToInt32(cmbMusteri.Text));

                BankaApp.müsteriList[müsteriIndex].HesapAc();

                MessageBox.Show(""+cmbMusteri.Text+"numaralı müşteriye hesap eklenmiştir");
            }
        }

        private void frmHesapAc_Load(object sender, EventArgs e)
        {
            foreach (Müsteri m in BankaApp.müsteriList)
            {
                cmbMusteri.Items.Add(m.müsteriNo);
            }
        }
    }
}
