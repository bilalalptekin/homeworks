using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_odv6
{
    public class Personel
    {
        public Personel()
        {

        }
        public Personel(String GelenAd, String GelenTelefon, String GelenAdres)
        {
            this.Ad = GelenAd;
            this.Telefon = GelenTelefon;
            this.Adres = GelenAdres;
        }

        string ad;

        public string Ad { get => ad; set => ad = value; }
        string telefon;
        public string Telefon { get => telefon; set => telefon = value; }
        string adres;
        public string Adres { get => adres; set => adres = value; }
        

        public override string ToString()
        {
            return Ad;
        }

        Bolum bolumu;
        public Bolum Bolumu { get => bolumu; set => bolumu = value; }
        public string detayYaz()
        {
            return $"{"Adı: " + this.Ad} {"TElefon: " + this.Telefon} {"Adres: " + this.Adres} {"Bölüm Adı: " + this.Bolumu.Ad} {"Bolüm Telefon: " + this.Bolumu.Telefon}";
        }
    }
}
