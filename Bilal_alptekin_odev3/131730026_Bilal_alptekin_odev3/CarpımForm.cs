using System;
using System.Windows.Forms;

namespace _131730026_Bilal_alptekin_odev3
{
    public partial class CarpımForm : Form
    {
        public CarpımForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 1; i <= 10; i++)
            {

                for (int y = 1; y < 11; y++)
                {
                    listBox1.Items.Add(i+"x"+y+"="+i*y);
                }
                    
            }
        }

        private void button1_Click(object sender, EventArgs e)

        {
            listBox1.Items.Clear();
            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            for (int i = baslangic; i <= bitis; i++)
            {
                
                for (int y = 1; y <= bitis; y++)
                {
                    listBox1.Items.Add(i + "x" + y + "=" + i * y);
                }
                if (i == 50)
                {
                    MessageBox.Show("Girilen Bİtiş Değeri 50'e Kadar Yazdırıldı ");
                    break;
                  
                }
            }
        }
    }
}
