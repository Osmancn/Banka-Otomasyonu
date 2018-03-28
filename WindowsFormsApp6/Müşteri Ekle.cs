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
    public partial class frmMusteriEkle : Form
    {
        public frmMusteriEkle()
        {
            InitializeComponent();

            cmbTür.Items.Add("Ticari Müşteri");
            cmbTür.Items.Add("Bireysel Müşteri");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public Banka BankaApp;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            if(txtAd.Text=="" || txtSoyad.Text=="" || txtTC.Text=="" || cmbTür.Text=="")
                 MessageBox.Show("Lütfen Bilgileri Eksiksiz " +
                    "Doldurduğunuzdan Emin Olunuz...");

            else if( 9999999999>Convert.ToDouble(txtTC.Text) ||
                         100000000000< Convert.ToDouble(txtTC.Text) )
                     MessageBox.Show("Tc kimliği eksik girdiniz");

            else if(TCKontrol(Convert.ToDouble(txtTC.Text)))
                MessageBox.Show("Böyle bir TC numaralı kullanıcı zaten mevcut");

            else
            {
                BankaApp.MüsteriEkle(txtAd.Text,txtSoyad.Text,
                    Convert.ToDouble(txtTC.Text),cmbTür.Text);

                MessageBox.Show(""+BankaApp.müsteriList[BankaApp.müsteriList.Count-1].müsteriNo
                    +" numaralı müşteri eklenmiştir");
            }
        }

       private bool TCKontrol(double tc)
       {
            bool kontrol=false;
            foreach (Müsteri m in BankaApp. müsteriList)
            {
                if(m.tc == tc)
                {
                    kontrol = true;
                    break;
                }
            }

            return kontrol;

        }

        private void frmMusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
