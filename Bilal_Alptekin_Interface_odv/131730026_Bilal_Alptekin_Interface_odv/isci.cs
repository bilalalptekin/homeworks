using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_Interface_odv
{
    public partial class isci : Ikisi,Iproje
    {
        string ad;
        string adres;
        double maas;
        string projeadi;
        double projekatki;
        public string Ad { get => ad; set => ad = value; }
        public string Adres { get => adres; set => adres = value; }
        public double Maas { get => maas; set => maas = value; }
        public string ProjeAdi { get => projeadi; set => projeadi=value; }
        public double Projekatki { get => projekatki; set => projekatki=value; }

        public double maasHesapla()
        {
            return this.Maas;
        }
        public override string ToString()
        {
            return $"{Ad} {ProjeAdi}";
        }
    }
}
