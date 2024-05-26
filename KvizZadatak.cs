using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeomProj
{
    internal class KvizZadatak : Zadatak,IVrsteZadataka
    {
        public KvizZadatak(string pitanje, TimeSpan vreme, string odgovor) : base(pitanje, vreme, odgovor)
        {
        }
    }
}
