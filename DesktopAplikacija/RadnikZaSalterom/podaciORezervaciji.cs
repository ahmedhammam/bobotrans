using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopAplikacija.Entiteti;

namespace DesktopAplikacija.RadnikZaSalterom
{
    public partial class podaciORezervaciji : Form
    {
        List<DAL.Entiteti.KupacKarte> kupci;
        KolekcijaLinija kl = KolekcijaLinija.Instanca;
        DAL.Entiteti.Korisnik prodavac;
        public podaciORezervaciji(DAL.Entiteti.Korisnik prodavac_)
        {
            InitializeComponent();
            //postavi bazu podataka karti
            kupci = DAL.DAL.Instanca.getDAO.getKupacKarteDAO().GetAll();
            kupci.AddRange(DAL.DAL.Instanca.getDAO.getKupacKarteSPopustomDAO().GetAll());
            cbLinije.Items.AddRange(kl.Linije.ToArray());
            prodavac = prodavac_;
        }

        private void podaciORezervaciji_Load(object sender, EventArgs e)
        {
            prikaziSveKupce();
        }

        private void prikaziSveKupce()
        {
            lbSpisakKarti.Items.Clear();

            foreach (DAL.Entiteti.KupacKarte kupac in kupci)
            {
                prikaziElement(kupac);
            }
        }

        private void prikaziElement(DAL.Entiteti.KupacKarte kupac)
        {
            ListViewItem sadasnji = lbSpisakKarti.Items.Add(kupac.Ime);
            sadasnji.SubItems.Add(String.Format("{0}, {1}", kupac.PocetnaStanica.Naziv, kupac.PocetnaStanica.Mjesto));
            sadasnji.SubItems.Add(String.Format("{0}, {1}", kupac.KrajnjaStanica.Naziv, kupac.KrajnjaStanica.Naziv));
            sadasnji.SubItems.Add(kupac.Voznja.VrijemePolaska.ToString("dd.MM.yy"));
            sadasnji.SubItems.Add(kupac.Voznja.VrijemePolaska.ToString("HH:mm:ss"));
            sadasnji.SubItems.Add(kupac.Sjedista.Count.ToString());
            sadasnji.SubItems.Add(kupac.proracunajCijenu().ToString());
            sadasnji.SubItems.Add(kupac.DatumIVrijemeKupovine.ToString("dd.MM.yy HH:mm:ss"));
            sadasnji.Tag = kupac;
        }

        private void prikaziPretrazeneKupce()
        {
            lbSpisakKarti.Items.Clear();

            foreach (DAL.Entiteti.KupacKarte kupac in kupci)
            {
                if (ispunjavaUslove(kupac))
                {
                    prikaziElement(kupac);
                }
            }
        }

        private bool ispunjavaUslove(DAL.Entiteti.KupacKarte kupac)
        {
            if (!(tbImeIPrez.Text == "") && !(tbImeIPrez.Text == kupac.Ime)) return false;
            if (cbLinije.SelectedIndex>-1)
            {
                DAL.Entiteti.Linija linija = cbLinije.SelectedItem as DAL.Entiteti.Linija;
                bool valja = false;
                foreach(DAL.Entiteti.Voznja voznja in linija.Voznje)
                {
                    if (voznja.SifraVoznje == kupac.Voznja.SifraVoznje) valja = true;
                }
                if (!valja) return false;
            }
            if (cbVoznje.SelectedIndex > -1)
            {
                DAL.Entiteti.Voznja voznja = cbVoznje.SelectedItem as DAL.Entiteti.Voznja;
                if (voznja.SifraVoznje != kupac.Voznja.SifraVoznje) return false;
            }
            if (cbPocStan.SelectedIndex > -1)
            {
                DAL.Entiteti.Stanica stanica = cbPocStan.SelectedItem as DAL.Entiteti.Stanica;
                if (stanica.SifraStanice != kupac.PocetnaStanica.SifraStanice) return false;
            }
            if (cbKrajStan.SelectedIndex > -1)
            {
                DAL.Entiteti.Stanica stanica = cbKrajStan.SelectedItem as DAL.Entiteti.Stanica;
                if (stanica.SifraStanice != kupac.KrajnjaStanica.SifraStanice) return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            brisanje();
        }

        private void brisanje()
        {
            if (lbSpisakKarti.CheckedIndices.Count > 0)
            {
                DialogResult rezultat = MessageBox.Show("Da li ste sigurni da želite poništiti odabrane karte","Pažnja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rezultat == DialogResult.Yes)
                {
                    //brisanje odabranih
                    brishi();
                }
            }
        }

        private void brishi()
        {
            foreach (int indeks in lbSpisakKarti.CheckedIndices)
            {
                try
                {
                    DAL.Entiteti.KupacKarte kupac = lbSpisakKarti.Items[indeks].Tag as DAL.Entiteti.KupacKarte;
                    DAL.DAL.Instanca.getDAO.getKupacKarteDAO().delete(kupac);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            prikaziPretrazeneKupce();
        }

        private void cbLinije_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbVoznje.Items.Clear();
            cbVoznje.SelectedText = "";
            cbPocStan.Items.Clear();
            cbPocStan.SelectedText = "";
            cbKrajStan.Items.Clear();
            cbKrajStan.SelectedText = "";
            if (cbLinije.SelectedIndex > -1)
            {
                //postavi voznju i stanice
                DAL.Entiteti.Linija linija = cbLinije.SelectedItem as DAL.Entiteti.Linija;
                cbVoznje.Items.AddRange(linija.Voznje.ToArray());
                cbPocStan.Items.AddRange(linija.Stanice.ToArray());
                cbKrajStan.Items.AddRange(linija.Stanice.ToArray());
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStampajKarte_Click(object sender, EventArgs e)
        {
                if (lbSpisakKarti.CheckedIndices.Count > 0)
                {
                    DialogResult rezultat = MessageBox.Show("Da li ste sigurni da želite štampati odabrane karte?", "Pažnja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (rezultat == DialogResult.Yes)
                    {
                        foreach (int indeks in lbSpisakKarti.CheckedIndices)
                        {
                            stampanjeRadi((lbSpisakKarti.Items[indeks].Tag as DAL.Entiteti.KupacKarte).SifraKupca);
                        }
                    }
                }
        }


        private void stampanjeRadi(long id)
        {
            try
            {
                try
                {
                    DAL.Entiteti.KupacKarte kupac = DAL.DAL.Instanca.getDAO.getKupacKarteDAO().getById(id);

                    //uzimanje spiska stanica
                    long idLinije = DAL.DAL.Instanca.getDAO.getVoznjaDAO().dajIdLinije(kupac.Voznja.SifraVoznje);
                    List<DAL.Entiteti.Stanica> stanice = DAL.DAL.Instanca.getDAO.getLinijaDAO().getById(idLinije).Stanice;
                    StampacKarti stampac = new StampacKarti(kupac, stanice, prodavac);
                    stampac.Stampaj();
                    //Ent

                }
                catch (Exception ex)
                {
                    //znaci kupac karte sa popustom je
                    DAL.Entiteti.KupacSaPopustom kupac = DAL.DAL.Instanca.getDAO.getKupacKarteSPopustomDAO().getById(id);

                    //uzimanje spiska stanica
                    long idLinije = DAL.DAL.Instanca.getDAO.getVoznjaDAO().dajIdLinije(kupac.Voznja.SifraVoznje);
                    List<DAL.Entiteti.Stanica> stanice = DAL.DAL.Instanca.getDAO.getLinijaDAO().getById(idLinije).Stanice;
                    StampacKarti stampac = new StampacKarti(kupac, stanice, prodavac);
                    stampac.Stampaj();
                }
            }
            catch
            {
                //MessageBox.Show("Neispravna šifra", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                id = -1;
            }
            if (id < 0) MessageBox.Show("Neispravna šifra", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
