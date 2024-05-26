using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeomProj
{
    public partial class frmSlobodanNivo : Form
    {
        public frmSlobodanNivo()
        {
            InitializeComponent();
        }
        public Point gornjiLevi;
        public int duzinaStr;
        public Point centar;
        private void frmSlobodanNivo_Load(object sender, EventArgs e)
        {
       
        }
       
        private Zadatak[] UnosSaFajla(string imeFajla)
        {
            Zadatak[] zadaci = new Zadatak[4];
            StreamReader red = new StreamReader(imeFajla);
            int brojac = 0;
            while (!red.EndOfStream)
            {
                string[] infoZad = red.ReadLine().Split('!');
                SlobodanZadatak a = new SlobodanZadatak(infoZad[0], TimeSpan.Parse(infoZad[1]), infoZad[2], (FormaResenja)(Convert.ToInt32(infoZad[3])), infoZad[4]);
                zadaci[brojac] = a;
                brojac++;
            }
            red.Close();

           return zadaci;
        }
    }
}
