﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace AgeomProj
{
    internal abstract class Zadatak
    {
        public string Pitanje {  get; }
        public TimeSpan Vreme { get; }
        public abstract double[] Odgovor { get; set; }
        public int TrenutniBrojSrca { get; set; } = 3;
        public double TrenutniBrojZvezda { get; set; } = 3;
        public Zadatak(string pitanje,TimeSpan vreme, double[]odgovor) 
        { 
            Pitanje = pitanje;
            Vreme = vreme;
            Odgovor = odgovor;
        }
        public void ZapocniOdbrojavanje() 
        {
            /*
            int min = Vreme.Minutes;
            int sek = Vreme.Seconds;
            int ukupnoSek = min * 60 + sek;
            while (ukupnoSek > 0)
            {
                int remainingMinutes = ukupnoSek / 60;
                int remainingSeconds = ukupnoSek % 60;
                Thread.Sleep(1000);
                ukupnoSek--;
            }*/
        }
        public void PauzirajOdbrojavanje()
        { }
        public int GubiZivot() {return TrenutniBrojSrca--;}
    }
}
