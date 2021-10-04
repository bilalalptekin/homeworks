using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_nkatmanlı1.DOMAIN
{
    class Departmant
    {
        private int id;
        private string bolumAd;
        private string bolumTelefon;

        public Departmant(int id,string bolumAd,string bolumTelefon)
        {
            this.id = id;
            this.bolumAd = bolumAd;
            this.bolumTelefon = bolumTelefon;
        }

        public string BolumAd { get => bolumAd; set => bolumAd = value; }
        public string BolumTelefon { get => bolumTelefon; set => bolumTelefon = value; }

        public Departmant( string bolumAd, string bolumTelefon)
        {
          
            this.bolumAd = bolumAd;
            this.bolumTelefon = bolumTelefon;
        }
        public override string ToString()
        {
            return $"{this.BolumAd} {this.BolumTelefon}";
        }

    }
}
