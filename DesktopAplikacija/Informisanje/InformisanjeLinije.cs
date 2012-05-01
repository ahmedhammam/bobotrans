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
    public partial class InformisanjeLinije : Form
    {

        private DesktopAplikacija.Entiteti.KolekcijaLinija kl = DesktopAplikacija.Entiteti.KolekcijaLinija.Instanca;
        private DAL.Entiteti.Linija selektiranaLinija;

        public InformisanjeLinije()
        {
            InitializeComponent();
            cbLinije.DataSource = kl.Linije;
            cbLinije.DisplayMember = "nazivLinije";
            
        }

        private void cbLinije_SelectedIndexChanged(object sender, EventArgs e)
        {
            selektiranaLinija = (cbLinije.SelectedItem as DAL.Entiteti.Linija);
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            dgvStanice.Rows.Clear();

            lblNazivLinije.Text = "Naziv linije: " + selektiranaLinija.NazivLinije;
            lblBrojStanica.Text = "Broj stanica: " + selektiranaLinija.Stanice.Count.ToString();
            lblSifraLinije.Text = "Sifra linije: " + selektiranaLinija.SifraLinije.ToString();

            for (int i = 0; i < selektiranaLinija.Stanice.Count; i++)
            {
                dgvStanice.Rows.Add(selektiranaLinija.Stanice[i].Naziv,selektiranaLinija.Stanice[i].Mjesto,selektiranaLinija.TrajanjeDoDolaska[i],selektiranaLinija.TrajanjeDoPolaska[i]);
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsBtnPrikaziVoznje_Click(object sender, EventArgs e)
        {
            InformisanjeVoznje iv = new InformisanjeVoznje(selektiranaLinija);
            iv.Show();
        }


    }
}
