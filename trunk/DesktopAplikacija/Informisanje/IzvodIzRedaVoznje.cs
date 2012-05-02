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
    public partial class IzvodIzRedaVoznje : Form
    {
        private DesktopAplikacija.Entiteti.KolekcijaStanica ks = DesktopAplikacija.Entiteti.KolekcijaStanica.Instanca;

        public IzvodIzRedaVoznje()
        {
            InitializeComponent();
            foreach (DAL.Entiteti.Stanica stanica in ks.Stanice)
                cbStanice.Items.Add(stanica.Naziv+", "+stanica.Mjesto);
        }

        private void cbStanice_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indeks = cbStanice.SelectedIndex;
            
            List<Entiteti.VoznjaNaStanici> dolazneVoznje = InformisanjeKomande.vratiPolazneVoznjeStanice(ks.Stanice[indeks]);
            List<Entiteti.VoznjaNaStanici> polazneVoznje = InformisanjeKomande.vratiDolazneVoznjeStanice(ks.Stanice[indeks]);

            dgvIzvodIzRedaVoznje.Rows.Clear();

            for (int i = 0; i < dolazneVoznje.Count; i++)
            {
                dgvIzvodIzRedaVoznje.Rows.Add(dolazneVoznje[i].NazivLinije,dolazneVoznje[i].Sati.ToString()+":"+dolazneVoznje[i].Minute.ToString("00"),polazneVoznje[i].Sati.ToString()+":"+polazneVoznje[i].Minute.ToString("00"));
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
