﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_nkatmanlı1.DAL
{
    class dbConnection
    {
        public MySqlConnection getConnection() 
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost; Database=nkatmanli; uid=bilalalptekin;pwd=123456;");
            connection.Open();
            return connection;


        }
    }
}
