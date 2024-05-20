using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeomProj
{
    public enum FormaResenja {broj, pravaEks, pravaImp, krug, elipsaHiperbola, parabola }
    internal class SlobodanZadatak : Zadatak
    {
        public string Hint { get; set; }
        public FormaResenja FormaResenja {  get; set; }
        public SlobodanZadatak(string pitanje, TimeSpan vreme, string odgovor, FormaResenja formaResenja) : base(pitanje, vreme, odgovor)
        {
            FormaResenja = formaResenja;
        }
    }
}
