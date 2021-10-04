using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _131730026_Bilal_Alptekin_odev8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                
               // MySqlCommand command = new MySqlCommand();
                //command.CommandText = "insert into personel (name,surname,adres,phone_number) values ('" + tbxIsim.Text + "','" + tbxSoyisim.Text + "','" + tbxAdres.Text + "','" + tbxTelefon.Text + "')";
                //command.Connection = (new DB()).getSqlConnection();
                //command.ExecuteNonQuery();
                (new MySqlCommand("insert into personel (name,surname,adres,phone_number) values ('" + tbxIsim.Text + "','" + tbxSoyisim.Text + "','" + tbxAdres.Text + "','" + tbxTelefon.Text + "')", (new DB()).getSqlConnection())).ExecuteNonQuery();
                MessageBox.Show("Başarıyla Database'e Eklendi");
                read();
                textboxClenaer();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Bir Problem Var : " + ex.Message);

            }
        }
        void textboxClenaer()
        {
            tbxIsim.Clear();
            tbxSoyisim.Clear();
            tbxAdres.Clear();
            tbxTelefon.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            read();
        }
        void read()
        {
            listBox1.Items.Clear();
            MySqlDataReader reader = ((new MySqlCommand("select *from personel", (new DB().getSqlConnection()))).ExecuteReader());
            while (reader.Read())
            {
                listBox1.Items.Add(new Personel(Convert.ToInt32(reader[0]), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString()));
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            new MySqlCommand("delete from personel where id=" + ((Personel)listBox1.SelectedItem).Id, (new DB().getSqlConnection())).ExecuteNonQuery();
            read();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            new UpdateForm((Personel)listBox1.SelectedItem).Show();
        }
    }
}
