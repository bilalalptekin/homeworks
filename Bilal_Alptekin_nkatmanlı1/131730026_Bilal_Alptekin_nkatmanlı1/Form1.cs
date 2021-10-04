using _131730026_Bilal_Alptekin_nkatmanlı1.DAL;
using _131730026_Bilal_Alptekin_nkatmanlı1.DOMAIN;
using _131730026_Bilal_Alptekin_nkatmanlı1.SERVICE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131730026_Bilal_Alptekin_nkatmanlı1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxAd.Text)|| String.IsNullOrWhiteSpace(tbxTel.Text))
            {
                MessageBox.Show("Lütfen Bir Bölüm ile ilgili kısımları Tam olarak Doldurun");
            }
            else
            {
                departmantDAO d = new departmantDAO();
                d.saveDepartman((new Departmant(tbxAd.Text, tbxTel.Text)));
                lstboxEklenen.Items.Clear();
                departmantLoad();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            departmantLoad();
            urunLoad();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxUrunAd.Text) || String.IsNullOrWhiteSpace(tbxUrunAdet.Text)|| String.IsNullOrWhiteSpace(tbxUrunFiyat.Text))
            {
                MessageBox.Show("Lütfen Bir Ürün ile ilgili kısımları Tam olarak Doldurun");
            }
            else
            {
                UrunService d = new UrunService();
                d.saveUrun(tbxUrunAd.Text,Convert.ToDouble(tbxUrunFiyat.Text),Convert.ToInt32(tbxUrunAdet.Text));
                lstboxUrun.Items.Clear();
                urunLoad();
            }
        }
        private void urunLoad()
        {
            foreach (Urun urun in (new UrunService().readUruns()))
            {
                lstboxUrun.Items.Add(urun.ToString());
            }
        }
        private void departmantLoad()
        {
            foreach (Departmant departmant in (new departmanService().readDepartmans()))
            {
                lstboxEklenen.Items.Add(departmant.ToString());
            }
        }
    }
}
