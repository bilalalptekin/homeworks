using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131730026_Bilal_Alptekin_odv6
{
    public partial class Form2 : Form
    {
        public Form2(Personel gelenPersonel)
        {
            InitializeComponent();
            listBox2.Items.Add(gelenPersonel);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add( new Bolum(tbxBolumAd.Text,tbxBolumTelefon.Text));
        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            Personel personel = (Personel)listBox2.SelectedItem;
            personel.Bolumu = (Bolum)listBox1.SelectedItem;
            listBox3.Items.Add(personel.detayYaz());
        }


    }
}
