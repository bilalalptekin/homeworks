using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131730026_Bilal_Alptekin_odev8
{
    public partial class UpdateForm : Form
    {
        int id;
        public UpdateForm(Personel personel)
        {
            InitializeComponent();
            tbxIsim.Text = personel.Isim;
            tbxSoyisim.Text = personel.Soyisim;
            tbxTelefon.Text = personel.Telefon;
            tbxAdres.Text = personel.Adres;
            id = personel.Id;
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            (new MySqlCommand("update personel set name='" + tbxIsim.Text + "',surname='" + tbxSoyisim.Text + "', phone_number='" + tbxTelefon.Text + "', adres='" + tbxAdres.Text + "' where id=" + (id), (new DB()).getSqlConnection())).ExecuteNonQuery();
            this.Hide();
            //new Form1().Show();
            
        }
    }
}
