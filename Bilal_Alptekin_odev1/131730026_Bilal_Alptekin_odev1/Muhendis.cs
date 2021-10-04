using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_odev1
{
    public class Muhendis:Personel
    {
        string proje;
        public Muhendis(string gAdSoyad,string gAdres,string gTel,double gMaas, int gMesaisaati,string gProje)
        {
            this.IsimSoyisim = gAdSoyad;
            this.Adres = gAdres;
            this.Telno = gTel;
            this.Maas = gMaas;
            this.Mesaisaati = gMesaisaati;
            this.Proje = gProje;
        }

        public string Proje { get => proje; set => proje = value; }
        public override double MaasHesapla()
        {
            return Maas + Mesaisaati * 10;
        }
    }
}
