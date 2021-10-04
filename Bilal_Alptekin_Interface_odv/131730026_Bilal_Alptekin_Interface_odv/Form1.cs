using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131730026_Bilal_Alptekin_Interface_odv
{
    public partial class Form1 : Form
    {
        isci gisci = new isci();
        bool dondu;
        yonetici gyonetici = new yonetici();
        public Form1()
        {
            InitializeComponent();
            dondu = false;
            
        }
        public Form1(isci isci,bool gdondu)
        {
            InitializeComponent();
            dondu = gdondu;
            gisci = isci;
            this.tbxAd.Text = gisci.Ad;
            this.tbxAdres.Text = gisci.Adres;
            this.tbxMaas.Text = Convert.ToString(gisci.Maas);
            this.cbxBolüm.Text= "İşçi";
            //dondu = true;
        }
        public Form1(yonetici yonetici,bool gdondu)
        {
            dondu = gdondu;
            InitializeComponent();
            gyonetici = yonetici;
            this.tbxAd.Text = gyonetici.Ad;
            this.tbxAdres.Text = gyonetici.Adres;
            this.tbxMaas.Text = Convert.ToString(gyonetici.Maas);
            this.cbxBolüm.Text = "Yönetici";
        }


        private void cbxBolüm_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(cbxBolüm.Text))
            {
                MessageBox.Show("Lütfen Bir Meslek Seçin");
            }
            else
            {
                switch (cbxBolüm.Text)
                {
                    case "İşçi":
                        gisci.Ad = tbxAd.Text;
                        //gisci.Adres = tbxAdres.Text;
                        gisci.Maas = Convert.ToDouble(tbxMaas.Text);
                        isciForm isciform = new isciForm(gisci);
                        if (dondu.Equals(false))
                        {
                            //this.Hide();
                            isciform.ShowDialog();
                        }dondu = false;
                        

                        break;
                    case "Yönetici":
                        gyonetici.Ad = tbxAd.Text;
                        //gyonetici.Adres = tbxAdres.Text;
                        gyonetici.Maas = Convert.ToDouble(tbxMaas.Text);
                        yöneticiForm yönetici = new yöneticiForm(gyonetici);
                        if (dondu.Equals(false))
                        {
                            //this.Hide();
                            yönetici.ShowDialog();
                        }
                        dondu = false;
                        break;

                    default:
                        
                        break;
                }
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            switch (cbxBolüm.Text)
            {
                case "İşçi":
                    //isci isci=;
                    //gisci.Ad = tbxAd.Text;
                    gisci.Adres = tbxAdres.Text;
                    //gisci.Maas = Convert.ToDouble(tbxMaas.Text);
                    lstboxEklenen.Items.Add(gisci);
                    break;
                case "Yönetici":
                    //gyonetici.Ad = tbxAd.Text;
                    gyonetici.Adres = tbxAdres.Text;
                    //gyonetici.Maas = Convert.ToDouble(tbxMaas.Text);
                    lstboxEklenen.Items.Add(gyonetici);
                    break;

                default:

                    break;
            }
        }


    }
}
