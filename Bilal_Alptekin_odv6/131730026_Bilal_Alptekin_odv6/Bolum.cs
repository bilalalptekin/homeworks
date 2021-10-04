using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_odv6
{
    public class Bolum
    {

        public Bolum(String GelenAd,String GelenTelefon)
        {
            this.Ad = GelenAd;
            this.Telefon = GelenTelefon;
        }
        string ad;
        string telefon;

        public string Ad { get => ad; set => ad = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public override string ToString()
        {
            return $"{Ad} {Telefon}"; 
        }
    }
}
