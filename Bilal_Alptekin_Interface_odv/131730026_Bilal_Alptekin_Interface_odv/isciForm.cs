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
    public partial class isciForm : Form
    {
        isci isci = new isci();
        public isciForm(isci gisci)
        {
            isci = gisci;
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            
            isci.Birim = cbxBirim.Text;
            isci.ProjeAdi = tbxProjeAdi.Text;
            isci.Projekatki = Convert.ToDouble(tbxProjeKatki.Text);
            isci.Tel = tbxTel.Text;
            Form1 form1 = new Form1(isci,true);           
            //form1.Show();
            this.Hide();

        }
    }
}
