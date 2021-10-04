using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _131730026_Bilal_Alptekin_Interface_odv
{
    interface Ikisi
    {
        string Ad { get; set; }
        string Adres { get; set; }
        double Maas { get; set; }
        double maasHesapla();
    }
}
