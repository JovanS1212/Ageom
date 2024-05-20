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
    internal class Prava : IElementSZ
    {
        public SlobodanZadatak SlobodanZadatak { get; set; }
        public PointF PozicijaEl { get; set; }
        public double N {  get; set; }
        public double K {  get; set; }
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public void Nacrtaj(Graphics g, frmUvod forma)
        {
            PointF gornji = new PointF();
            gornji.Y = 0;
            gornji.X = (10 - (float)this.N)/(float)K;//10 se ubacuje jer je to max kodomena a tu trazimo gornju tacku
            PointF donji = new PointF();
            //donji.Y = ;
            donji.X = (-10 - (float)this.N) / (float)K;// -10 se ubacuje jer je to min kodomena a tu trazimo donju tacku
        }
    }
}
