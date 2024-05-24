using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeomProj
{
    internal class Krug : IElementSZ
    {
        public PointF PozicijaEl { get; set; }
        public double R { get; set; }
        public SlobodanZadatak SlobodanZadatak { get; set; }

        public Krug(SlobodanZadatak slobodanZadatak,PointF centar, double r) 
        {
            SlobodanZadatak = slobodanZadatak;
            PozicijaEl = centar;
            R = r;
        }   
        public void Nacrtaj(Graphics g, Point centar, int strKvad)
        {
            Pen olovka = new Pen(Color.Black, 3);
            float x = Convert.ToSingle(strKvad*PozicijaEl.X + centar.X - strKvad*R);
            float y = Convert.ToSingle(strKvad*PozicijaEl.Y + centar.Y - strKvad*R);
            g.DrawEllipse(olovka, x, y, 2*Convert.ToSingle(R)*strKvad, 2*Convert.ToSingle(R)*strKvad);
        }
    }
}
