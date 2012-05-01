using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopAplikacija.Informisanje
{
    public partial class InformisanjeVoznje : Form
    {
        private DAL.Entiteti.Linija odabranaLinija;
        public InformisanjeVoznje(DAL.Entiteti.Linija l)
        {
            InitializeComponent();
            odabranaLinija = l;
            lblSifraLinije.Text += " " + l.SifraLinije.ToString();
            lblNazivLinije.Text += " " + l.NazivLinije;
            lblBrojVoznji.Text += " " + l.RasporediVoznje.Count;
        }

    }
}
