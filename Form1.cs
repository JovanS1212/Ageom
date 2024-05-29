using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AgeomProj
{
    public partial class frmUvod : Form
    {
        public Point gornjiLevi;
        public int duzinaStr;
        bool pocetniMeni;
        public Point centar;
        Point a;//a je gornja tacka trougla igraj, b je donja
        Point b;
        public frmUvod()
        {
            InitializeComponent();
        }
        public void IzracunajGornjiLevi()//RESITI PROBLEM SA RESIZEOM
        {
            Point gL = new Point();
            if (this.Width >= this.Height) 
            {
                gL.X = (this.ClientSize.Width - this.ClientSize.Height) / 2;
                gL.Y = 0;
                gornjiLevi = gL;
                duzinaStr = this.ClientSize.Height - this.ClientSize.Height % 20;
            }
            else
            {
                gL.X = 0;
                gL.Y = (this.ClientSize.Height - this.ClientSize.Width) / 2; 
                gornjiLevi = gL;
                duzinaStr = this.ClientSize.Width - this.ClientSize.Width % 20;
            }
            centar.X = gornjiLevi.X + duzinaStr / 2;
            centar.Y = gornjiLevi.Y + duzinaStr / 2;
        }
        private void frmUvod_Load(object sender, EventArgs e)
        {
            IzracunajGornjiLevi();
            pocetniMeni = true;
        }
        public void VeLicinaLokacijaSvega()
        {
            lblIgraj.Font = new Font("Georgia", (int)(duzinaStr/20));
            lblIgraj.Left = centar.X + 5;
            lblIgraj.Top = centar.Y - lblIgraj.Width / 5;
            btnFormule.Width = (int)(3 * duzinaStr / 20);
            btnFormule.Height = (int)(1.5*duzinaStr/20);
            btnFormule.Left = centar.X + duzinaStr/2 - btnFormule.Width;
            btnFormule.Top = centar.Y + (int)(duzinaStr/2.5) - btnFormule.Height;  
            btnFormule.Font = new Font("Georgia", (int)(duzinaStr / 45));
        }
        private void ucitajPozadinu(Graphics g)
        {
            int strKvad = duzinaStr / 20;
            Pen pozadina = new Pen(Color.FromArgb(192, 192, 192), 1);
            Point gornja = new Point();
            gornja.X = gornjiLevi.X;
            gornja.Y = gornjiLevi.Y;
            Point donja = new Point();
            donja.X = gornjiLevi.X;
            donja.Y = gornjiLevi.Y+duzinaStr;
            Point leva = new Point();
            leva.X = gornjiLevi.X;
            leva.Y = gornjiLevi.Y;
            Point desna = new Point();
            desna.X = leva.X + duzinaStr;
            desna.Y = gornjiLevi.Y;
            for (int i = 0; i < duzinaStr / strKvad; i++)
            {
                g.DrawLine(pozadina, gornja, donja);
                g.DrawLine(pozadina, leva, desna);
                gornja.X += strKvad;
                donja.X += strKvad;
                leva.Y += strKvad;
                desna.Y += strKvad;
            }
            pozadina.Color = Color.Black;
            pozadina.Width = 5;
            g.DrawLine(pozadina, gornjiLevi, new Point(gornjiLevi.X + duzinaStr, gornjiLevi.Y));//gornja granica
            g.DrawLine(pozadina, new Point(gornjiLevi.X, gornjiLevi.Y + duzinaStr), new Point(gornjiLevi.X + duzinaStr, gornjiLevi.Y + duzinaStr));//donja granica
            g.DrawLine(pozadina, gornjiLevi, new Point(gornjiLevi.X, gornjiLevi.Y + duzinaStr));//leva granica
            g.DrawLine(pozadina, new Point(gornjiLevi.X + duzinaStr, gornjiLevi.Y), new Point(gornjiLevi.X + duzinaStr, gornjiLevi.Y + duzinaStr));//desna granica
        }
        private void frmUvod_Paint(object sender, PaintEventArgs e)
        {
            int strKvad = duzinaStr / 20;
            VeLicinaLokacijaSvega();
            ucitajPozadinu(e.Graphics);
            if (pocetniMeni)
            {
                lblIgraj.Visible = true;
                lblIgraj.Enabled = true;
                btnFormule.Visible = true;
                btnFormule.Enabled = true;
                a.X = centar.X - 5 * strKvad;
                a.Y = centar.Y - 3 * strKvad;
                b.X = centar.X - 5 * strKvad;
                b.Y = centar.Y + 3 * strKvad;
                Pen trougaoIgraj = new Pen(Color.Black, 5);
                Point[] crtanjeTrougao = { a, b, centar };
                e.Graphics.DrawPolygon(trougaoIgraj, crtanjeTrougao);
            }
            else
            {
                lblIgraj.Visible = false;
                lblIgraj.Enabled = false;
                btnFormule.Visible = false;
                btnFormule.Enabled = false;
            }
            PointF c = new PointF();
            c.X = 0;
            c.Y = 0;
            SlobodanZadatak joj = new SlobodanZadatak(null, new TimeSpan(0, 0, 0), " ", FormaResenja.broj, " ");
            SlobodanZadatak[] lele = new SlobodanZadatak[10];
            Nivo<SlobodanZadatak> n = new Nivo<SlobodanZadatak>(0, 0, 0, lele);
            Krug k = new Krug(joj, c, 5);
            k.Nacrtaj(e.Graphics,centar,strKvad);
            Prava p = new Prava(joj,c, 0, 1);
            p.Nacrtaj(e.Graphics, centar, strKvad);

        }

        private void frmUvod_ResizeEnd(object sender, EventArgs e)
        {
            IzracunajGornjiLevi();
            this.Refresh();
        }

        private void frmUvod_SizeChanged(object sender, EventArgs e)
        {
            IzracunajGornjiLevi();
            this.Refresh();
        }

        private void lblIgraj_Click(object sender, EventArgs e)
        {
            pocetniMeni = false;
            this.Refresh();
        }
        public decimal PovrsinaTrougla(Point a, Point b, Point c)
        {
            return Math.Round(Convert.ToDecimal(0.5*Math.Abs(a.X*(b.Y - c.Y) + b.X * (c.Y - a.Y) + c.X * (a.Y - b.Y))),2);
        }
        private void frmUvod_MouseClick(object sender, MouseEventArgs e)
        {
            int ha = -a.X;
            int stra = b.Y - a.Y;
            decimal povrsinaGlavnog = Math.Round(Convert.ToDecimal(stra * ha) / 2, 2);
            Point m = new Point();
            m.X = e.X;
            m.Y = e.Y;
            decimal p1 = PovrsinaTrougla(a, b, m);
            decimal p2 = PovrsinaTrougla(a, centar, m);
            decimal p3 = PovrsinaTrougla(centar, b, m);
            if (povrsinaGlavnog == (p1 + p2 + p3))
            {
                pocetniMeni = false;
                this.Refresh();
            }
        }
    }
}
