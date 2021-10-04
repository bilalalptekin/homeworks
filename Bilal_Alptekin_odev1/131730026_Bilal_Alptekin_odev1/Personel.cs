using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_odev1
{
    public class Personel
    {
        String isimsoyisim;
        //String soyisim;
        String telno;
        String adres;
        Double maas;
        int mesaisaati;
        //Double mesaiucreti;

        public String IsimSoyisim { get { return isimsoyisim; } set { isimsoyisim = value; } }
        //public String Soyisim { get { return soyisim; } set { soyisim = value; } }
        public String Telno { get { return telno; } set { telno = value; } }
        public String Adres { get { return adres; } set { adres = value; } }
        public Double Maas { get { return maas; } set { maas = value; } }

        public int Mesaisaati { get => mesaisaati; set => mesaisaati = value; }
        //public double Mesaiucreti { get => mesaiucreti; set => mesaiucreti = value; }

        public override string ToString()
        {
            return $"{ this.IsimSoyisim } ({this.Maas})";

        }
        public virtual double MaasHesapla()
        {
            return maas+mesaisaati*5;
        }

    }
}
