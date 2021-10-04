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
    public partial class yöneticiForm : Form
    {
        yonetici yonetici = new yonetici();
        public yöneticiForm(yonetici gyonetici)

        {
            yonetici = gyonetici;
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            yonetici.Yonettigibolum = cbxYönBolüm.Text;
            yonetici.Extraucreti = Convert.ToDouble(tbxİstedigiMaas.Text);
            
            Form1 form1 = new Form1(yonetici,true);
            //form1.Show();
            this.Hide();
        }
    }
}
