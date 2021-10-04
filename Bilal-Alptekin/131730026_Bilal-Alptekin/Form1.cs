using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131730026_Bilal_Alptekin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToInt32(tbxSayı1.Text);
            double sayi2 = Convert.ToInt32(tbxSayi2.Text);

            double sonuc = sayi1 * sayi2;
            lblSonuc.Text = $"Sonuç: {sonuc}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String gelendeger = comboBox1.Text;
            double sayi1 = Convert.ToInt32(tbxSayı1.Text);
            double sayi2 = Convert.ToInt32(tbxSayi2.Text);
            double sonuc;
            if (gelendeger=="Topla")
            {
                sonuc=sayi1 + sayi2;
                lblSonuc.Text = $"Sonuç: {sonuc}";
            }
            else if(gelendeger=="Çıkar")
            {
                sonuc = sayi1 - sayi2;
                lblSonuc.Text = $"Sonuç: {sonuc}";
            }
            else if (gelendeger == "Çarp")
            {
                sonuc = sayi1 * sayi2;
                lblSonuc.Text = $"Sonuç: {sonuc}";
            }
            else if (gelendeger == "Böl")
            {
                sonuc = sayi1 / sayi2;
                lblSonuc.Text = $"Sonuç: {sonuc}";
            }
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToInt32(tbxSayı1.Text);
            double sayi2 = Convert.ToInt32(tbxSayi2.Text);
          
            double sonuc = sayi1 + sayi2;
            lblSonuc.Text = $"Sonuç: {sonuc}";

        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToInt32(tbxSayı1.Text);
            double sayi2 = Convert.ToInt32(tbxSayi2.Text);

            double sonuc = sayi1 - sayi2;
            lblSonuc.Text = $"Sonuç: {sonuc}";
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToInt32(tbxSayı1.Text);
            double sayi2 = Convert.ToInt32(tbxSayi2.Text);

            double sonuc = sayi1 / sayi2;
            lblSonuc.Text = $"Sonuç: {sonuc}";
        }
    }
}
