using MySql.Data.MySqlClient;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _131730026_Bilal_Alptekin_odev8
{
    public class DB
    {

        public MySqlConnection getSqlConnection()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = "Server=localhost; Database=131730026odev8; Uid=root; Pwd=''";
            connection.Open();
            return connection;
        }

       
        
        
  
            
    }
}
