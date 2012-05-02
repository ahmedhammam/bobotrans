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
        private string []dani = {"","Ponedjeljak","Utorak","Srijeda","Četvrtak","Petak","Subota","Nedjelja"};
        private DAL.Entiteti.Linija odabranaLinija;
        public InformisanjeVoznje(DAL.Entiteti.Linija l)
        {
            InitializeComponent();
            odabranaLinija = l;
            lblSifraLinije.Text += " " + l.SifraLinije.ToString();
            gbLinija.Text = l.NazivLinije;
            lblBrojVoznji.Text += " " + l.RasporediVoznje.Count;

            foreach (DAL.Entiteti.RasporedVoznje rv in odabranaLinija.RasporediVoznje)
            {
                cbVoznje.Items.Add(dani[rv.DanUSedmici] + ", " + rv.Vrijeme.Hour.ToString() +":" + rv.Vrijeme.Minute.ToString("00"));
            }
            cbVoznje.SelectedIndex = 0;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {
            int indeks = cbVoznje.SelectedIndex;
            int sati = odabranaLinija.RasporediVoznje[indeks].Vrijeme.Hour;
            int minute = odabranaLinija.RasporediVoznje[indeks].Vrijeme.Minute;
            int tmpSatiDoDolaska = new int(), tmpMinuteDoDolaska = new int();
            int tmpSatiDoPolaska = new int(), tmpMinuteDoPolaska = new int();

            dgvVremena.Rows.Clear();

            for (int i = 0; i < odabranaLinija.Stanice.Count; i++)
            {
                saberiMinute(sati, minute, odabranaLinija.TrajanjeDoDolaska[i], ref tmpSatiDoDolaska, ref tmpMinuteDoDolaska);
                saberiMinute(sati, minute, odabranaLinija.TrajanjeDoPolaska[i], ref tmpSatiDoPolaska, ref tmpMinuteDoPolaska);
                dgvVremena.Rows.Add(tmpSatiDoDolaska.ToString() + ":" + tmpMinuteDoDolaska.ToString("00"), tmpSatiDoPolaska.ToString() + ":" + tmpMinuteDoPolaska.ToString("00"));
                dgvVremena.Rows[i].HeaderCell.Value = odabranaLinija.Stanice[i].Naziv+", "+odabranaLinija.Stanice[i].Mjesto;
            }
        }

        private void saberiMinute(int satiPoc,int minutePoc,int minuteDodati, ref int rezSati,ref int rezMinute)
        {
            rezMinute = minutePoc + minuteDodati;
            rezSati = (satiPoc + rezMinute / 60) % 24;
            rezMinute %= 60;
        }

    }
}
