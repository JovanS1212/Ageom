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
        public void GornjiLevi()
        {
            Point gL = new Point();
            if (this.Width >= this.Height) 
            {
                gL.X = (this.Width - this.Height) / 2;
                gL.Y = 0;
                gornjiLevi = gL;
                duzinaStr = this.Height;
                centar.X = gornjiLevi.X + this.Height / 2;
                centar.Y = gornjiLevi.Y + this.Height / 2;
            }
            else
            {
                gL.X = 0;
                gL.Y = (this.Height - this.Width) / 2; 
                gornjiLevi = gL;
                duzinaStr = this.Width;
                centar.X = gornjiLevi.X + this.Width / 2;
                centar.Y = gornjiLevi.Y + this.Width / 2;
            }
        }
        private void frmUvod_Load(object sender, EventArgs e)
        {
            GornjiLevi();
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
        private void frmUvod_Paint(object sender, PaintEventArgs e)
        {
            VeLicinaLokacijaSvega();
            int strKvad = duzinaStr/20;
            Pen pozadina = new Pen(Color.FromArgb(192, 192, 192), 1);
            Point gornja = new Point();
            gornja.X = gornjiLevi.X;
            gornja.Y = 0;
            Point donja = new Point();
            donja.X = gornjiLevi.X;
            donja.Y = this.Height;
            Point leva = new Point();
            leva.X = gornjiLevi.X;
            leva.Y = 0;
            Point desna = new Point();
            desna.X = leva.X + duzinaStr;
            desna.Y = 0;
            for (int i = 0;i < duzinaStr/strKvad; i++)
            {
                e.Graphics.DrawLine(pozadina,gornja,donja);
                e.Graphics.DrawLine(pozadina, leva, desna);
                gornja.X += strKvad;
                donja.X += strKvad;
                leva.Y += strKvad;
                desna.Y += strKvad;
            }
            pozadina.Color = Color.Black;
            pozadina.Width = 5;
            e.Graphics.DrawLine(pozadina, gornjiLevi, new Point(gornjiLevi.X + duzinaStr,gornjiLevi.Y));//gornja granica
            e.Graphics.DrawLine(pozadina, new Point(gornjiLevi.X, this.Height-42), new Point(gornjiLevi.X + duzinaStr, this.Height-42));//donja granica
            e.Graphics.DrawLine(pozadina, gornjiLevi, new Point(gornjiLevi.X, this.Height));//leva granica
            e.Graphics.DrawLine(pozadina, new Point(gornjiLevi.X + duzinaStr, 0), new Point(gornjiLevi.X + duzinaStr, this.Height));//desna granica
            if (pocetniMeni)
            {
                lblIgraj.Visible = true;
                lblIgraj.Enabled = true;
                btnFormule.Visible = true;
                btnFormule.Enabled = true;
                a.X = centar.X - 5 * strKvad;
                a.Y = centar.Y - 3 * strKvad;
                b.X = centar.X - 5 * strKvad;
                b.Y = centar.Y + 2 * strKvad;
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
        }

        private void frmUvod_ResizeEnd(object sender, EventArgs e)
        {
            GornjiLevi();
            this.Refresh();
        }

        private void frmUvod_SizeChanged(object sender, EventArgs e)
        {
            GornjiLevi();
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
