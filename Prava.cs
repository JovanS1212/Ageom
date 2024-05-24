using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeomProj
{
    internal class Prava : IElementSZ//abc implicitni, kn eksplicitni
    {
        public SlobodanZadatak SlobodanZadatak { get; set; }
        public PointF PozicijaEl { get; set; }
        public double N { get;}
        public double K { get;}
        public double A { get;}
        public double B { get;}
        public double C { get;}
        public bool Eksplicitni {  get;}
        public Prava(SlobodanZadatak slobodanZadatak, PointF pozicijaEl, double n, double k)
        {
            SlobodanZadatak = slobodanZadatak;
            PozicijaEl = pozicijaEl;
            N = n;
            K = k;
            Eksplicitni = true;
        }
        public Prava(SlobodanZadatak slobodanZadatak, PointF pozicijaEl, double a, double b, double c)
        {
            SlobodanZadatak = slobodanZadatak;
            PozicijaEl = pozicijaEl;
            A = a;
            B = b;
            C = c;
            Eksplicitni = false;
        }
        public (double, double) UEksplicitni()
        {
            double k, n;
            k = -(A / B);
            n = -(C / A);
            return (k, n);
        }
        public void Nacrtaj(Graphics g, Point centar, int strKvad)
        {
            PointF gornji = new PointF();
            PointF donji = new PointF();
            if (Eksplicitni)
            {
                //ima 6 slucajeva za odredjivanje granicnih tacaka u odnosu na maxX i maxY i minX i minY
                double maxYPrave = IzracunajY(10), minYPrave = IzracunajY(-10);
                double maxXPrave = IzracunajX(10), minXPrave = IzracunajX(-10);
                Pen olovka = new Pen(Color.Black, 3);
                if (maxXPrave <= 10 && minXPrave >= -10)//od dole ka gore ide prava
                {
                    gornji.X = Convert.ToSingle(centar.X + maxXPrave * strKvad);
                    gornji.Y = Convert.ToSingle(centar.Y + 10 * strKvad);
                    donji.X = Convert.ToSingle(centar.X + minXPrave * strKvad);
                    donji.Y = Convert.ToSingle(centar.Y - 10 * strKvad);
                    g.DrawLine(olovka, gornji, donji);
                }
            }
            else
            {
                (double k, double n) = UEksplicitni(); 
            }
        }
        public double IzracunajY(double x)
        {
            return this.K*x + this.N;
        }
        public double IzracunajX(double y)
        {
            return (y - this.N)/this.K;
        }
    }
}
