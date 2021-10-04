using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131730026_Bilal_alptekin_odev3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarpımForm frm = new CarpımForm();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            listViewCift.Items.Clear();
            listViewTek.Items.Clear();
            
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Lütfen Değer Giriniz");
            }
            else
            {
                int baslangic = Convert.ToInt32(textBox1.Text);
                int bitis = Convert.ToInt32(textBox2.Text);
                for (int i = baslangic; i <= bitis; i++)
                {

                    if (i % 2 == 0)
                    {
                        listViewCift.Items.Add(i.ToString());
                    }
                    else
                    {
                        listViewTek.Items.Add(i.ToString());
                    }

                }
            }
        }
    }
}
