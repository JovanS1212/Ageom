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
        public override double[] Odgovor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Hint { get; set; }
        public FormaResenja FormaResenja {  get; set; }
        public SlobodanZadatak(string pitanje, TimeSpan vreme, double[] odgovor, FormaResenja formaResenja) : base(pitanje, vreme, odgovor)
        {
            FormaResenja = formaResenja;
        }
    }
}
