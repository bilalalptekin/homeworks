using _131730026_Bilal_Alptekin_nkatmanlı1.DOMAIN;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_nkatmanlı1.DAL
{
    class UrunDAO
    {
        internal ArrayList readUrun()
        {
            ArrayList readedUruns = new ArrayList();
            MySqlDataReader read = (new MySqlCommand("select *from urunler ", (new dbConnection()).getConnection())).ExecuteReader();
            while (read.Read())
            {
                readedUruns.Add(new Urun(Convert.ToInt32(read[0]), read[1].ToString(), Convert.ToDouble(read[2]), Convert.ToInt32(read[3])));
            }
            return readedUruns;
        }
        public void saveUrun(Urun urun)
        {
            (new MySqlCommand("insert into urunler(urunAd,urunFiyat,urunAdet) values ('" + urun.UrunAd+ "','" + urun.UrunFiyat+ "','"+urun.UrunAdet +"')", (new dbConnection()).getConnection())).ExecuteNonQuery();
        }
    }
}
