using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131730026_Bilal_Alptekin_odev1
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

        private void btnEkle_Click(object sender, EventArgs e)
        {
           Personel personel;
            
            
            
                switch (cbxMeslek.Text)
                {
                    case "İşçi":
                        personel = new Iscı(tbxAdSoyad.Text,tbxAdres.Text,tbxTelefon.Text,Convert.ToDouble(tbxMaas.Text),Convert.ToInt32(tbxMesaiSaati.Text),cbxBirim.Text);
                        lstboxEklenen.Items.Add(personel);
                        break;
                    case "Mühendis":
                    personel = new Muhendis(tbxAdSoyad.Text, tbxAdres.Text, tbxTelefon.Text, Convert.ToDouble(tbxMaas.Text), Convert.ToInt32(tbxMesaiSaati.Text), cbxProje.Text);
                    lstboxEklenen.Items.Add(personel);
                    break;

                    default:
                    MessageBox.Show("Lütfen Meslek Seçin");
                        break;
                }
            }

        private void cbxMeslek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbxMeslek.Text))
            {
                MessageBox.Show("Lütfen Bir Meslek Seçin");
            }
            else
            {
                switch (cbxMeslek.Text)
                {
                    case "İşçi":
                        cbxBirim.Visible = true;
                        cbxProje.Visible = false;
                        lblBirim.Visible = true;
                        lblProje.Visible = false;
                        break;
                    case "Mühendis":
                        cbxBirim.Visible = false;
                        cbxProje.Visible = true;
                        lblBirim.Visible = false;
                        lblProje.Visible = true;
                        break;

                    default:
                        cbxBirim.Visible = false;
                        cbxProje.Visible = false;
                        lblBirim.Visible = false;
                        lblProje.Visible = false;
                        break;
                }
            }
        }

        private void lstboxEklenen_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show((((Personel)lstboxEklenen.SelectedItem).MaasHesapla()).ToString());
        }
    }

    
    
}
