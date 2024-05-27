using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeomProj
{
    internal class Nivo<T> where T : IVrsteZadataka
    {
        public int TrenutniBrojSrca { get; set; } = 3;
        public float TrenutniBrojZvezda { get; set; } = 3;
        public int Tezina { get; set; } 
        public TimeSpan VremeNivo 
        {  get
            {
                Zadatak[] zadaci = Zadaci as Zadatak[];
                TimeSpan ukupno = TimeSpan.Zero;
                for (int i = 0; i < zadaci.Length; i++)
                {
                    ukupno += zadaci[i].VremeZadatak;
                }
                return ukupno;
            } 
        }
        public T[] Zadaci { get; set; }
        public Nivo(int trenutniBrojSrca, float trenutniBrojZvezda, int tezina, T[] zadaci)
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
