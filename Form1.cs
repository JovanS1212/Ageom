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
        double Levi, Gornji;  
        public frmUvod()
        {
            InitializeComponent();
        }
        public (double, double) LeviGornji()
        {
            double x = -1, y = -1;
            if (this.Width <= this.Height) 
            {
                x = (this.Height - this.Width) / 2;
                y = 0;
                return (x, y);
            }
            else
            {
                x = 0;
                y = (this.Height - this.Width) / 2; 
                return (x, y);
            }
        }
        private void frmUvod_Load(object sender, EventArgs e)
        {
            //80 kvadratica vodoravno, 45 horizontalno
            (Levi, Gornji) = LeviGornji();
        }

        private void frmUvod_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUvod_ResizeEnd(object sender, EventArgs e)
        {
            (Levi, Gornji) = LeviGornji();
        }
    }
}
