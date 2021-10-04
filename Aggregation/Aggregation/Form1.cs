using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aggregation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Motor m = new Motor();
            m.Beygir = Convert.ToInt32(tbxBeygir.Text);
            m.Motorgucu= cbxMotorGucu.Text;
            m.Tork= Convert.ToInt32(tbxTork.Text);
            Araba a = new Araba();
            a.Kapisayisi= Convert.ToInt32(cbxKapiSayisi.Text);
            a.Renk= cbxRenk.Text;
            a.Marka = cbxMarka.Text;
            a.Motor = m;
            lstboxEklenen.Items.Add(a);
        }
    }
}
