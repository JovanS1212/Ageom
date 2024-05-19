using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeomProj
{
    public partial class frmUvod : Form
    {
        Point gornjiLevi;
        int duzinaStr;
        bool pocetniMeni;
        Point centar;
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
            }
            else
            {
                gL.X = 0;
                gL.Y = (this.Height - this.Width) / 2; 
                gornjiLevi = gL;
                duzinaStr = this.Width;
            }
            centar.X = gornjiLevi.X + duzinaStr/2;
            centar.Y = gornjiLevi.Y + duzinaStr / 2;
        }
        private void frmUvod_Load(object sender, EventArgs e)
        {
            GornjiLevi();
            pocetniMeni = true;
        }

        private void frmUvod_Paint(object sender, PaintEventArgs e)
        {
            int strKvad = duzinaStr/20;
            Pen pozadina = new Pen(Color.FromArgb(192,192,192),1);
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
            if(pocetniMeni)
            {
                Point a = new Point();//a je gornja tacka dugmeta igraj, b je donja
                Point b = new Point();
                a.X = centar.X - 5 * strKvad;
                a.Y = centar.Y - 3 * strKvad;
                b.X = centar.X - 5 * strKvad;
                b.Y = centar.Y + 2 * strKvad;
                Pen trougaoIgraj = new Pen(Color.Black, 5);
                Point[] crtanjeTrougao = { a, b, centar };
                e.Graphics.DrawPolygon(trougaoIgraj, crtanjeTrougao);
                lblIgraj.Font = new Font("Georgia", (int)(strKvad));
                lblIgraj.Left = centar.X + 5;
                lblIgraj.Top = centar.Y - lblIgraj.Width/5;
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

        }
    }
}
