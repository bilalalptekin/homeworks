using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_odev1
{
    public class Iscı : Personel
    {
        string birim;
        public Iscı(string gAdSoyad, string gAdres, string gTel, double gMaas, int gMesaisaati, string gBirim)
        {
            this.IsimSoyisim = gAdSoyad;
            this.Adres = gAdres;
            this.Telno = gTel;
            this.Maas = gMaas;
            this.Mesaisaati = gMesaisaati;
            this.Birim = gBirim;
        }

        public string Birim { get => birim; set => birim = value; }

        public override double MaasHesapla()
        {
            return Maas+Mesaisaati*5;
        }
    }

}