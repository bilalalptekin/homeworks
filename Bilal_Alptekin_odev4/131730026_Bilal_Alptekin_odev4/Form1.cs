using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131730026_Bilal_Alptekin_odev4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] notArrays;
        int sayı = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            int notadet = Convert.ToInt32(tbxNotSayisi.Text);
            int[] notArray = new int[notadet];
            notArrays = notArray;
            panel2.Visible = true;
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (sayı<notArrays.Length)
            {
                notArrays[sayı] = Convert.ToInt32(textBox1.Text);
               
                lstboxEkle.Items.Add(notArrays[sayı]);
                textBox1.Text = "";
                textBox1.Focus();
               
            }
           
            sayı++;
            lblNotGirin.Text = $"{sayı + 1}. Notu Giriniz";
            if (sayı ==notArrays.Length)
            {
                textBox1.Enabled = false;
                panel3.Visible = true;
                lblNotGirin.Text = $"{sayı}. Notu Giriniz";
                lblAciklama.Text = $"Toplam: {sayı} Adet\nNot Ortalamasaı: {notArrays.Sum() / sayı}\nEn Düşük Not: {notArrays.Min()}\nEn Yüksek Not: {notArrays.Max()}";
                MessageBox.Show("Bütün Değerleri Girdiniz");
                
            }

           

            
            
        }

    
    }
}
