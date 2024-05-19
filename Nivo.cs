using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeomProj
{
    internal class Nivo
    {
        public int TrenutniBrojSrca { get; set; } = 3;
        public double TrenutniBrojZvezda { get; set; } = 3;
        public int Tezina { get; set; } 
        public TimeSpan VremeNivo 
        {  get
            {
                TimeSpan ukupno = TimeSpan.Zero;
                for (int i = 0; i < Zadaci.Length; i++)
                {
                    ukupno += Zadaci[i].VremeZadatak;
                }
                return ukupno;
            } 
        }
        public Zadatak[] Zadaci { get; set; }
        public Nivo(int trenutniBrojSrca, double trenutniBrojZvezda, int tezina, Zadatak[] zadaci)
        {
            TrenutniBrojSrca = trenutniBrojSrca;
            TrenutniBrojZvezda = trenutniBrojZvezda;
            Tezina = tezina;
            Zadaci = zadaci;
        }
        public void Restartuj() { }
        public int GubiZivot() {return TrenutniBrojSrca--;}
    }
}
