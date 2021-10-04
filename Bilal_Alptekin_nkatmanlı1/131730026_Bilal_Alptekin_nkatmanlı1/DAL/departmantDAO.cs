using System;
using System.Collections;
using MySql.Data.MySqlClient;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _131730026_Bilal_Alptekin_nkatmanlı1.DOMAIN;

namespace _131730026_Bilal_Alptekin_nkatmanlı1.DAL
{
    class departmantDAO
    {
        internal ArrayList readDepartmans()
        {
            ArrayList readedDepartmans = new ArrayList();
            MySqlDataReader read = (new MySqlCommand("select *from bolum ",(new dbConnection()).getConnection())).ExecuteReader();
            while (read.Read())
            {
                readedDepartmans.Add(new Departmant(Convert.ToInt32(read[0]), read[1].ToString(), read[2].ToString()));
            }
            return readedDepartmans;
        }
        public void saveDepartman(Departmant departman)
        {
            (new MySqlCommand("insert into bolum(bolumAd,bolumTelefon) values ('" + departman.BolumAd + "','" + departman.BolumTelefon + "')", (new dbConnection()).getConnection())).ExecuteNonQuery();
        }
    }
}
