using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_Interface_odv
{
    public class yonetici : Personel, Ikisi
    {
        string ad;
        string adres;
        double maas;
        string yonettigibolum;
        double extraucreti;
        public string Ad { get => ad; set => ad = value; }
        public string Adres { get => adres; set => adres = value; }
        public double Maas { get=>maas; set=>maas=value; }
        public string Yonettigibolum { get => yonettigibolum; set => yonettigibolum = value; }
        public double Extraucreti { get => extraucreti; set => extraucreti = value; }

        public double maasHesapla()
        {
            return this.Maas;
        }
        public override string ToString()
        {
            return $"{Ad} {Yonettigibolum}";
        }
    }
}
