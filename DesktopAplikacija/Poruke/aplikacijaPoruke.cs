using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DAL;



namespace DesktopAplikacija.Poruke
{
    public partial class aplikacijaPoruke : Form
    {
        private DAL.DAL d = DAL.DAL.Instanca;
        private DAL.DAL.PorukeDAO pd;
        private DAL.DAL.KorisnikDAO kd;
        private List<DAL.Entiteti.Poruka> primljene;
        private List<DAL.Entiteti.Poruka> poslane;
        private Entiteti.KolekcijaKorisnika kk = Entiteti.KolekcijaKorisnika.Instanca;
        private DAL.Entiteti.Korisnik logovani;
        private enum Prikazuje
        {
            poslane = 1,
            primljene = 2
        };

        private Prikazuje staPrikazuje = Prikazuje.primljene;

        public aplikacijaPoruke(DAL.Entiteti.Korisnik k)
        {
            try
            {
                d.kreirajKonekciju();
                pd = d.getDAO.getPorukeDAO();
                kd = d.getDAO.getKorisnikDAO();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            InitializeComponent();

            try
            {
                primljene = pd.getByExample("idPrimaoca", k.SifraKorisnika.ToString());
                poslane = pd.getByExample("idPosiljaoca", k.SifraKorisnika.ToString());
                logovani = k;

                tscbKorisnici.ComboBox.DataSource = kk.Korisnici;
                tscbKorisnici.ComboBox.DisplayMember = "imeIPrezime";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            prikaziPoruke(primljene,true);

        }

        private void listView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = (sender as ListView).Columns[e.ColumnIndex].Width;
        }

        private void b_Izadi_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void poslanaPoruka(DAL.Entiteti.Poruka p)
        {
            poslane.Add(p);
        }

        private void tsbPoslane_Click(object sender, EventArgs e)
        {
            prikaziPoruke(poslane, false);
        }

        private void prikaziPoruke(List<DAL.Entiteti.Poruka> poruke,bool primljene)
        {
            staPrikazuje = primljene ? Prikazuje.primljene : Prikazuje.poslane;
            gbPoruke.Text = primljene ? "Primljene poruke" : "Poslane poruke";
            lvPoruke.Items.Clear();
            for (int i = poruke.Count - 1; i > -1; i--)
            {
                if (primljene)
                    lvPoruke.Items.Add(kk.getNameByUsername(poruke[i].Posiljaoc));
                else
                    lvPoruke.Items.Add(kk.getNameByUsername(poruke[i].Primalac));

                lvPoruke.Items[poruke.Count - 1-i].SubItems.Add(poruke[i].VrijemeSlanja.ToString("dd.MM.yyyy hh:mm"));
                lvPoruke.Items[poruke.Count - 1-i].SubItems.Add(poruke[i].Tekst);
                lvPoruke.Items[poruke.Count - 1-i].Tag = poruke[i];
            }
        }


        private void primljeneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prikaziPoruke(primljene, true);
        }

        private void tsbPrimljene_Click(object sender, EventArgs e)
        {
            prikaziPoruke(primljene, true);
        }

        private void tsbPretragaPoImenu_Click(object sender, EventArgs e)
        {
            if (tscbKorisnici.Text == "")
            {
                MessageBox.Show("Izaberite radnika");
                return;
            }

            List<DAL.Entiteti.Poruka> nove = new List<DAL.Entiteti.Poruka>();

            foreach (DAL.Entiteti.Poruka p in primljene)
                if ((tscbKorisnici.SelectedItem as DAL.Entiteti.Korisnik).Username == p.Posiljaoc)
                    nove.Add(p);

            prikaziPoruke(nove, true);
                
        }

        private void tsbPretragaPoslanih_Click(object sender, EventArgs e)
        {
            if (tscbKorisnici.Text == "")
            {
                MessageBox.Show("Izaberite radnika");
                return;
            }

            List<DAL.Entiteti.Poruka> nove = new List<DAL.Entiteti.Poruka>();

            foreach (DAL.Entiteti.Poruka p in poslane)
                if ((tscbKorisnici.SelectedItem as DAL.Entiteti.Korisnik).Username == p.Primalac)
                    nove.Add(p);

            prikaziPoruke(nove, false);
        }

        private void tsbNova_Click(object sender, EventArgs e)
        {
            NovaPoruka np = new NovaPoruka(logovani,this);
            np.Show();
        }

        private void izađiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void primljeneToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            prikaziPoruke(primljene, true);
        }

        private void poslaneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prikaziPoruke(poslane, false);
        }

        private void lvPoruke_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count == 0) return;

            rtbTekst.Text = (lv.SelectedItems[0].Tag as DAL.Entiteti.Poruka).Tekst;
        }

        private void tsbIzbrisi_Click(object sender, EventArgs e)
        {
            DialogResult dres = MessageBox.Show("Da li ste sigurni da zelite obrisati oznacene poruke?", "Obrisati?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dres == DialogResult.Yes)
            {
                rtbTekst.Text = "";
                try
                {
                    DAL.Entiteti.Poruka p;

                    foreach (ListViewItem lvi in lvPoruke.CheckedItems)
                    {
                        p = lvi.Tag as DAL.Entiteti.Poruka;

                        if (staPrikazuje == Prikazuje.poslane)
                        {
                            poslane.Remove(p);
                        }
                        else
                            primljene.Remove(p);

                        lvPoruke.Items.Remove(lvi);
                        pd.delete(p);
                    }
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

        private void izadiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void novaPorukaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NovaPoruka np = new NovaPoruka(logovani, this);
            np.Show();
        }

    }
}
