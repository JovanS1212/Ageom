using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeomProj
{
    internal class KvizZadatak : Zadatak
    {
        public override double[] Odgovor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public KvizZadatak(string pitanje, TimeSpan vreme, double[] odgovor) : base(pitanje, vreme, odgovor)
        {
        }
    }
}
