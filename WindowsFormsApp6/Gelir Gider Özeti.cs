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
    public partial class frmGelirGiderOzt : Form
    {
        public frmGelirGiderOzt()
        {
            InitializeComponent();
        }

        public Banka BankaApp { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            grdGelirGider.DataSource = null;
            grdGelirGider.DataSource = BankaApp.Gelir_GiderOzetListesi();
        }
    }
}
