using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composition
{
    public class Araba
    {
        int kapisayisi;
        string renk;
        Motor motor;
        string marka;

        public Araba(Motor gmotor)
        {
            this.Motor = gmotor;
        }

        public int Kapisayisi { get => kapisayisi; set => kapisayisi = value; }
        public string Renk { get => renk; set => renk = value; }
        public Motor Motor { get => motor; set => motor = value; }
        public string Marka { get => marka; set => marka = value; }

        public override string ToString()
        {
            return $"{(Marka) + " " + (motor.Motorgucu) + " " + (renk)}";
        }
    }
}
