using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeomProj
{
    public enum FormaResenja {broj,tacka, pravaEks, pravaImp, krug, elipsaHiperbola, parabola,tekst }
    internal class SlobodanZadatak : Zadatak, IVrsteZadataka
    {
        
        public FormaResenja FormaResenja {  get; set; }
        
        public string Hint { get; set; }

        public SlobodanZadatak(string pitanje, TimeSpan vreme,string hint,FormaResenja formaResenja, string odgovor ) : base(pitanje, vreme, odgovor)
        {
            FormaResenja = formaResenja;
            Hint = hint;
        }
    }
}
