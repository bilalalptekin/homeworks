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
    class departmanService
    {
        internal ArrayList readDepartmans()
        {
            return (new departmantDAO().readDepartmans());
        }
        internal void saveDepartmans(string bolumAd,string bolumTelefon)
        {
            (new departmantDAO()).saveDepartman(new Departmant(bolumAd,bolumTelefon));
        }
    }
}
