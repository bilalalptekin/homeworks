using _131730026_Bilal_Alptekin_nkatmanlı1.DAL;
using _131730026_Bilal_Alptekin_nkatmanlı1.DOMAIN;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_nkatmanlı1.SERVICE
{
    internal class UrunService
    {
        internal ArrayList readUruns()
        {
            return (new UrunDAO().readUrun());
        }
        internal void saveUrun(string urunAd, double urunFiyat,int urunAdet)
        {
            (new UrunDAO()).saveUrun(new Urun(urunAd, urunFiyat,urunAdet));
        }
    }
}
