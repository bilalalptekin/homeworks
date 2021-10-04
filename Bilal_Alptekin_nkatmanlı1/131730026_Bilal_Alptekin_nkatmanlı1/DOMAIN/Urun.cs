using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_nkatmanlı1.DOMAIN
{
    class Urun
    {
        private int id;
        private string urunAd;
        private double urunFiyat;
        private int urunAdet;

        public int Id { get => id; set => id = value; }
        public string UrunAd { get => urunAd; set => urunAd = value; }
        public double UrunFiyat { get => urunFiyat; set => urunFiyat = value; }
        public int UrunAdet { get => urunAdet; set => urunAdet = value; }

        public Urun(int id, string urunAd, double urunFiyat, int urunAdet)
        {
            this.id = id;
            this.urunAd = urunAd;
            this.urunFiyat = urunFiyat;
            this.urunAdet = urunAdet;
        }
        public Urun( string urunAd, double urunFiyat, int urunAdet)
        {
         
            this.urunAd = urunAd;
            this.urunFiyat = urunFiyat;
            this.urunAdet = urunAdet;
        }
        public override string ToString()
        {
            return $"{this.UrunAd} {this.UrunFiyat} {this.UrunAdet}";
        }
    }
}
