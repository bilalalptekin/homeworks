using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggregation
{
    public class Motor
    {
        int  tork, beygir;
        string motorgucu;
        public string Motorgucu { get => motorgucu; set => motorgucu = value; }
        public int Tork { get => tork; set => tork = value; }
        public int Beygir { get => beygir; set => beygir = value; }
    }
}
