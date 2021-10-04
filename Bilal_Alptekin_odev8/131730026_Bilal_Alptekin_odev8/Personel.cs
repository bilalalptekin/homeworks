using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_odev8
{
    public class Personel

    {
        public Personel(int _idgelen,string _adgelen,string _soyadgelen,string _adresgelen,string _telefongelen)
        {
            this.Id = _idgelen;
            this.Isim = _adgelen;
            this.Soyisim = _soyadgelen;
            this.Adres = _adresgelen;
            this.Telefon=_telefongelen;
        }
        private int id;
        private string isim;
        private string soyisim;
        private string telefon;
        private string adres;
        


        public int Id { get => id; set => id = value; }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public string Telefon { get => telefon; set => telefon = value; }
        public string Adres { get => adres; set => adres = value; }

        public override string ToString()
        {
            return ($"{Isim} {Soyisim}").ToString();
        }
    }
}
