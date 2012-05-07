using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopAplikacija.Informisanje;
using DesktopAplikacija.Entiteti;

namespace DesktopAplikacija.RadnikZaSalterom
{
    public partial class aplikacijaSalter : Form
    {
        DAL.DAL d = DAL.DAL.Instanca;
        KolekcijaLinija kl = KolekcijaLinija.Instanca;
        DAL.DAL.VoznjaDAO vd;
        List<DAL.Entiteti.Voznja> voznje;
        List<DAL.Entiteti.Stanica> staniceUVoznji;
        List<bool> zauzetostMijestaTrenutna;
        List<DAL.Entiteti.TipPopusta> tipPopusta;
        List<int> odabranaMjesta;
        int velicinaBusaTrenutnog;

        public aplikacijaSalter()
        {
            InitializeComponent();
            try
            {
                d.kreirajKonekciju();
                vd = d.getDAO.getVoznjaDAO();
                voznje = vd.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void najjeftinijiPutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NajjeftinijiPut np = new NajjeftinijiPut();
            np.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            odabranaMjesta = new List<int>();
            d.kreirajKonekciju();
            DAL.Entiteti.Linija odabranaLinija = comboBox1.SelectedItem as DAL.Entiteti.Linija;
            voznje = odabranaLinija.Voznje;
         for (int i=0;i<voznje.Count;i++)
          {
              listBox1.Items.Add(voznje[i].SifraVoznje.ToString());
              listBox1.Items[i].SubItems.Add(voznje[i].VrijemePolaska.ToString("dd.MM.yyyy"));
              listBox1.Items[i].SubItems.Add(voznje[i].VrijemePolaska.ToString("HH:mm:ss"));
              listBox1.Items[i].SubItems.Add(voznje[i].Autobus.SifraAutobusa.ToString());
          }
         staniceUVoznji = odabranaLinija.Stanice;
         foreach (DAL.Entiteti.Stanica v in odabranaLinija.Stanice)
         {
             comboBox2.Items.Add(String.Format("{0}, {1}", v.Naziv, v.Mjesto));
             comboBox3.Items.Add(String.Format("{0}, {1}", v.Naziv, v.Mjesto));
         }
            
        }

        private void aplikacijaSalter_Load(object sender, EventArgs e)
        {
            d.kreirajKonekciju();
            foreach (DAL.Entiteti.Linija l in kl.Linije)
            {
                comboBox1.Items.Add(l);
            }
            textBox1.Text = "0";

            tipPopusta = d.getDAO.getKupacKarteSPopustomDAO().dajTipovePopusta();
            foreach (DAL.Entiteti.TipPopusta tP in tipPopusta)
            {
                comboBox4.Items.Add(tP.TipPopusta1.ToString());
            }

            comboBox4.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateujBrojSlobodnihSjedista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            foreach (DAL.Entiteti.Linija al in kl.Linije)
            {
                if (al.NazivLinije != comboBox1.Text) brojac++;
            }
            if (comboBox1.Text=="")
            {
                MessageBox.Show("Niste selektovali liniju!");
            }
            else if (brojac == kl.Linije.Count)
            {
                MessageBox.Show("Upisana linija ne postoji !"); return;
            }
            else if(comboBox1.Text!="")
            {
                    DAL.Entiteti.Linija odabranaLinija = comboBox1.SelectedItem as DAL.Entiteti.Linija;
                    CijeneNaLiniji cl = new CijeneNaLiniji(odabranaLinija);
                    cl.Show();
            }
        }
        private void informisanjeOLinijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformisanjeLinije il = new InformisanjeLinije();
            il.Show();
        }

        private void izvodIzRedaVožnjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzvodIzRedaVoznje irv = new IzvodIzRedaVoznje();
            irv.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NajjeftinijiPut np = new NajjeftinijiPut();
            np.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            InformisanjeLinije il = new InformisanjeLinije();
            il.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            IzvodIzRedaVoznje irv = new IzvodIzRedaVoznje();
            irv.Show();
        }

        private void pozoviRezervacijuSjedista()
        {
            //ovdje pozivas onu formu sto si radio u WPF i kad klikne na ono sjediste nek se otvori forma na kojoj se mogu unijeti
            //podaci onoga ko rezervise kartu i to spasiti u bazu-napravljena je "podaciORezervaciji" i isto tako klikom na zauzeta sjedista
            // nek se otvori forma gdje ce se prikazati ko je rezervisao kartu i omoguciti otkazivanje
            RezervacijaSjedistaUBusu irv = new RezervacijaSjedistaUBusu(velicinaBusaTrenutnog,zauzetostMijestaTrenutna,odabranaMjesta,this);
            irv.Show();
        }

        private void updateujBrojSlobodnihSjedista()
        {
            odabranaMjesta = new List<int>();
            textBox1.Text = "0";
            if (listBox1.SelectedItems.Count > 0 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > comboBox2.SelectedIndex)
            {
                int odgovor = 0;
                velicinaBusaTrenutnog = voznje[listBox1.SelectedItems[0].Index].Autobus.BrojSjedista;
                try
                {
                    List<DAL.Entiteti.KupacKarte> kupciKarti = new List<DAL.Entiteti.KupacKarte>();
                    List<DAL.Entiteti.KupacSaPopustom> kupciKartiSPopustom = new List<DAL.Entiteti.KupacSaPopustom>();
                    zauzetostMijestaTrenutna = new List<bool>();
                    for (int i = 0; i < velicinaBusaTrenutnog; i++) zauzetostMijestaTrenutna.Add(false);
                    kupciKarti = d.getDAO.getKupacKarteDAO().GetAll();
                    kupciKartiSPopustom = d.getDAO.getKupacKarteSPopustomDAO().GetAll();
                    foreach (DAL.Entiteti.KupacKarte kupac in kupciKarti)
                    {
                        if(kupac.Voznja.SifraVoznje==voznje[listBox1.SelectedItems[0].Index].SifraVoznje)
                        {
                            if (dajIndexStanice(kupac.PocetnaStanica) < comboBox3.SelectedIndex
                                ||
                                dajIndexStanice(kupac.PocetnaStanica) > comboBox2.SelectedIndex)
                            {
                                foreach (int mjesto in kupac.Sjedista)
                                {
                                    odgovor++;
                                    zauzetostMijestaTrenutna[mjesto - 1] = true;
                                }
                            }
                        }
                    }
                    foreach (DAL.Entiteti.KupacSaPopustom kupac in kupciKartiSPopustom)
                    {
                        if (kupac.Voznja.SifraVoznje == voznje[listBox1.SelectedItems[0].Index].SifraVoznje)
                        {
                            if (dajIndexStanice(kupac.PocetnaStanica) < comboBox3.SelectedIndex
                                ||
                                dajIndexStanice(kupac.PocetnaStanica) > comboBox2.SelectedIndex)
                            {
                                foreach (int mjesto in kupac.Sjedista)
                                {
                                    odgovor++;
                                    zauzetostMijestaTrenutna[mjesto - 1] = true;
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                textBox1.Text = (velicinaBusaTrenutnog - odgovor).ToString();
            }
        }

        private int dajIndexStanice(DAL.Entiteti.Stanica stan)
        {
            for (int i = 0; i < staniceUVoznji.Count; i++)
                if (staniceUVoznji[i].SifraStanice == stan.SifraStanice) return i;
            throw new Exception("Greška sa stanicama");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count == 1)
            {
                d.kreirajKonekciju();
                int odabranaVoznja = listBox1.SelectedItems[0].Index;
                int izabranaSifra = Convert.ToInt32(voznje[odabranaVoznja].Autobus.SifraAutobusa);
                PodaciOAutobusu p = new PodaciOAutobusu(izabranaSifra);
                p.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pozoviRezervacijuSjedista();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateujBrojSlobodnihSjedista();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateujBrojSlobodnihSjedista();
        }

        public void postaviRezervacijuMijesta(List<int> odabir)
        {
            odabranaMjesta = new List<int>();
            foreach (int mjesto in odabir)
            {
                odabranaMjesta.Add(mjesto);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0 && comboBox2.SelectedIndex > -1 && comboBox3.SelectedIndex > comboBox2.SelectedIndex)
            {
                DAL.Entiteti.Stanica prvaStanica = staniceUVoznji[comboBox2.SelectedIndex];
                DAL.Entiteti.Stanica drugaStanica = staniceUVoznji[comboBox3.SelectedIndex];
                DAL.Entiteti.Voznja voznja = voznje[listBox1.SelectedIndices[0]];
                DAL.Entiteti.Linija odabranaLinija = comboBox1.SelectedItem as DAL.Entiteti.Linija;
                double cijena = odabranaLinija.vratiCijenu(prvaStanica,drugaStanica);
                List<double> cijene = new List<double>();
                for (int i = 0; i < odabranaMjesta.Count; i++)
                {
                    cijene.Add(cijena * (1 - tipPopusta[comboBox4.SelectedIndex].VrijednostPopusta / 100.0));
                }
                if (tipPopusta[comboBox4.SelectedIndex].VrijednostPopusta == 0)
                {
                    DAL.Entiteti.KupacKarte kupac = new DAL.Entiteti.KupacKarte(textBox2.Text, prvaStanica,drugaStanica,voznja, odabranaMjesta, cijene, System.DateTime.Today);
                }
                else
                {
                    DAL.Entiteti.KupacSaPopustom kupac = new DAL.Entiteti.KupacSaPopustom(textBox2.Text, prvaStanica, drugaStanica, voznja, odabranaMjesta, cijene, System.DateTime.Today, tipPopusta[comboBox4.SelectedIndex].VrijednostPopusta, textBox3.Text, (DAL.TipoviPodataka.TipoviKupaca)(tipPopusta[comboBox4.SelectedIndex].Indeks));
                }
            }
        }
    }
}
