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
    public partial class NajjeftinijiPut : Form
    {
        private Entiteti.KolekcijaStanica ks = Entiteti.KolekcijaStanica.Instanca;

        public NajjeftinijiPut()
        {
            InitializeComponent();

            foreach (DAL.Entiteti.Stanica stanica in ks.Stanice)
            {
                cbPocetna.Items.Add(stanica.Naziv + ", " + stanica.Mjesto);
                cbKrajnja.Items.Add(stanica.Naziv + ", " + stanica.Mjesto);
            }

            cbPocetna.SelectedIndex = 0;
            cbKrajnja.SelectedIndex = 0;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzracunaj_Click(object sender, EventArgs e)
        {
            Entiteti.Put najjeftinijiPut = InformisanjeKomande.vratiNajjeftinijiPut(ks.Stanice[cbPocetna.SelectedIndex], ks.Stanice[cbKrajnja.SelectedIndex]);
            tbCijena.Text = najjeftinijiPut.Cijena.ToString();
            rtbOpis.Text = najjeftinijiPut.OpisPuta;
        }

        private void NajjeftinijiPut_Load(object sender, EventArgs e)
        {

        }
    }
}
