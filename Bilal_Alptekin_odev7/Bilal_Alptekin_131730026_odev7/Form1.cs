using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilal_Alptekin_131730026_odev7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection();
                connection.ConnectionString = "Server=localhost; Database=131730026odev; Uid=root; Pwd=''";
                connection.Open();
                MySqlCommand command = new MySqlCommand();
                command.CommandText = "insert into personel (name_surname,adress,phone_number) values ('" + tbxNameSurname.Text + "','" + tbxAdress.Text + "','" + tbxPhoneNumber.Text + "')";
                command.Connection = connection;
                command.ExecuteNonQuery();
                MessageBox.Show("Başarıyla Database'e Eklendi");
                tbxAdress.Clear();
                tbxNameSurname.Clear();
                tbxPhoneNumber.Clear();


            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata Oluştu \n"+ex.Message);
            }
                
           
        }
    }
}
