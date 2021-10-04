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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(new Personel(tbxAd.Text, tbxTelefon.Text, tbxAdres.Text)); 
            tbxAd.Clear();
            tbxAdres.Clear();
            tbxTelefon.Clear();
            
           
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            (new Form2((Personel)listBox1.SelectedItem)).Show();
        }
    }
}
