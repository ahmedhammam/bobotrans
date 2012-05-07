using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DAL.Entiteti;

namespace DesktopAplikacija.Menadzer
{
    public partial class UredjivanjeLinije : Form
    {
        private string[] dani = { "", "Ponedjeljak", "Utorak", "Srijeda", "Četvrtak", "Petak", "Subota", "Nedjelja" };
        private Linija linija;
        private PregledLinija pozvanOd;
        private DesktopAplikacija.Entiteti.KolekcijaStanica ks = DesktopAplikacija.Entiteti.KolekcijaStanica.Instanca;
        private List<Stanica> moguceStanice = new List<Stanica>();

        private int trajanjeDoDolaska = 0, trajanjeDoPolaska = 0;
        private int redniBroj = 0;
        private bool dodanaStanica = false;
        private DesktopAplikacija.Entiteti.KolekcijaLinija kl = DesktopAplikacija.Entiteti.KolekcijaLinija.Instanca;

        public UredjivanjeLinije(Linija l, PregledLinija pl)
        {
            InitializeComponent();
            linija = l;
            pozvanOd = pl;

            popuniKomponente();
            
        }


        void popuniKomponente()
        {
            lblSifra.Text += linija.SifraLinije.ToString();
            tbNaziv.Text = linija.NazivLinije;

            popuniStanice();
            popuniCijene();
            popuniRasporedeVoznji(linija.RasporediVoznje);
        }

        void popuniStanice()
        {
            for (int i = 0; i < linija.Stanice.Count; i++)
            {
                lvStanice.Items.Add(linija.Stanice[i].SifraStanice.ToString());
                lvStanice.Items[i].SubItems.Add(linija.Stanice[i].Naziv);
                lvStanice.Items[i].SubItems.Add(linija.Stanice[i].Mjesto);
                lvStanice.Items[i].SubItems.Add(linija.TrajanjeDoDolaska[i].ToString());
                lvStanice.Items[i].SubItems.Add(linija.TrajanjeDoPolaska[i].ToString());
                lvStanice.Items[i].Tag = linija.Stanice[i];
            }

            popuniComboBoxStanicama();
            popuniIndekse();
        }

        void popuniComboBoxStanicama()
        {
            
            for(int i=0; i< ks.Stanice.Count;i++)
            {
                if (linija.sadrziStanicu(ks.Stanice[i]) < 0)
                {
                    cbStanice.Items.Add(ks.Stanice[i].Naziv + " - " + ks.Stanice[i].Mjesto);
                    moguceStanice.Add(ks.Stanice[i]);
                }
                
            }

           cbStanice.SelectedIndex = 0;
        }

        void popuniIndekse()
        {
            for (int i = 1; i <= linija.Stanice.Count;i++ )
                cbRedniBroj.Items.Add(i);
            cbRedniBroj.SelectedIndex = 0;
        }

        void popuniCijene()
        {
            DataGridViewCellStyle crveno = new DataGridViewCellStyle();
            crveno.BackColor = System.Drawing.Color.Red;

            for (int i = 1; i < linija.Stanice.Count; i++)
                dgvCijene.Columns.Add("col" + i.ToString(), linija.Stanice[i].Naziv);
            for (int i = 0; i < linija.Cijene.Count; i++)
            {
                dgvCijene.Rows.Add();
                dgvCijene.Rows[i].HeaderCell.Value = linija.Stanice[i].Naziv + ", " + linija.Stanice[i].Mjesto;
                for (int j = 0; j < i; j++)
                {
                    dgvCijene.Rows[i].Cells[j].Style = crveno;
                    dgvCijene.Rows[i].Cells[j].ReadOnly = true;
                }
                   

                for (int j = 0; j < linija.Cijene[i].Count; j++)
                {
                    dgvCijene.Rows[i].Cells[j + i].Value = linija.Cijene[i][j];
                }
            }
        }

        void popuniRasporedeVoznji(List<RasporedVoznje> rasporedi)
        {
            for (int i = 0; i < rasporedi.Count; i++)
            {
                lvRasporedi.Items.Add(rasporedi[i].SifraRasporedaVoznji.ToString());
                lvRasporedi.Items[i].SubItems.Add(dani[rasporedi[i].DanUSedmici]);
                lvRasporedi.Items[i].SubItems.Add(rasporedi[i].Vrijeme.Hour.ToString()+":"+rasporedi[i].Vrijeme.Minute.ToString("00"));
                lvRasporedi.Items[i].SubItems.Add(rasporedi[i].PotrebanBrojSjedista.ToString());
                lvRasporedi.Items[i].SubItems.Add(rasporedi[i].SifraAutobusa.ToString());
            }
        }

        private void lvStanice_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = (sender as ListView).Columns[e.ColumnIndex].Width;
        }

        private void lvRasporedi_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = (sender as ListView).Columns[e.ColumnIndex].Width;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbMinute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(e.KeyChar.ToString(), "\\d+"))
                e.Handled = true;
        }

        void validirajUnosStanica()
        {
            if (tbDolazak.Text == "" || tbPolazak.Text == "")
                throw new Exception("Niste unijeli dolazak i polazak!");

            trajanjeDoPolaska = Convert.ToInt16(tbPolazak.Text);
            trajanjeDoDolaska = Convert.ToInt16(tbDolazak.Text);

            if (redniBroj > linija.Stanice.Count)
                throw new Exception("Preveliki redni broj stanice!");

            if (trajanjeDoDolaska > trajanjeDoPolaska)
                throw new Exception("Polazak veci od dolaska!");

            if (trajanjeDoDolaska < linija.TrajanjeDoPolaska[redniBroj - 1] || trajanjeDoPolaska > linija.TrajanjeDoDolaska[redniBroj])
                throw new Exception("Vremena dolaska i polaska nisu u skladu sa drugim stanicama");
        }

        private void updateDgvCijene(int redniBroj, int polazak,int dolazak, Stanica stanica)
        {
            DataGridViewColumn dgvc = new DataGridViewColumn();
            dgvc.HeaderText = stanica.Naziv;
            dgvc.CellTemplate = new DataGridViewTextBoxCell();

            dgvCijene.Columns.Insert(redniBroj, dgvc);

            dgvCijene.Rows.Insert(redniBroj);
            dgvCijene.Rows[redniBroj].HeaderCell.Value = stanica.Naziv + "-" + stanica.Mjesto;

            DataGridViewCellStyle crveno = new DataGridViewCellStyle();
            crveno.BackColor = System.Drawing.Color.Red;
            

            for (int i = 0; i < redniBroj; i++)
            {
                dgvCijene.Rows[redniBroj].Cells[i] .Style = crveno;
                dgvCijene.Rows[redniBroj].Cells[i].ReadOnly = true;
            }
            for (int i = redniBroj + 1; i < dgvCijene.Rows.Count; i++)
            {
                dgvCijene.Rows[i].Cells[redniBroj].Style = crveno;
                dgvCijene.Rows[i].Cells[redniBroj].ReadOnly = true;
            }
        }

        private void btnDodajStanicu_Click(object sender, EventArgs e)
        {
            redniBroj = cbRedniBroj.SelectedIndex + 1;
            
            try
            {
                validirajUnosStanica();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }
            Stanica odabranaStanica = moguceStanice[cbStanice.SelectedIndex];


            updateDgvCijene(redniBroj, trajanjeDoPolaska, trajanjeDoDolaska, odabranaStanica);
            dodanaStanica = true;
            btnDodajStanicu.Enabled = false;
        }

        bool sadrziSlovo(string s)
        {
            foreach (char c in s)
            {
                if (char.IsLetter(c))
                    return true;
            }
            return false;
        }

        private List<List<double>> validirajUneseneCijene()
        {
            double cijena;
            string sadrzaj;
            int brojStanica = linija.Stanice.Count;
            List<List<double>> cijene = new List<List<double>>();
            if(dodanaStanica)
                brojStanica++;

            for (int i = 0; i < brojStanica - 1; i++)
            {
                  cijene.Add(new List<double>());
                  for (int j = 0; j < brojStanica  - i - 1; j++)
                        cijene[i].Add(0);
            }

            for (int i = 0; i < dgvCijene.Rows.Count; i++)
            {
                for (int j = i; j < dgvCijene.ColumnCount; j++)
                {
                    if (dgvCijene.Rows[i].Cells[j].Value==null) throw new Exception("Neispravna cijena!");
                    sadrzaj = dgvCijene.Rows[i].Cells[j].Value.ToString();
                    if(sadrzaj=="" || sadrziSlovo(sadrzaj) || !double.TryParse(sadrzaj,out cijena) || cijena<0)
                    {
                        throw new Exception("Neispravna cijena!");
                    }
                    else
                    {
                        cijene[i][j-i] = cijena;
                    }
                }
            }
            return cijene;
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {

            List<List<double>> cijene;
            try
            {
               cijene = validirajUneseneCijene();
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
                return;
            }

            linija.NazivLinije = tbNaziv.Text;
            linija.Cijene = cijene;

            kl.updateujLiniju(linija);

            /*
            
            System.IO.StreamWriter tw = new System.IO.StreamWriter("D:\\izlaz.txt");

            for (int i = 0; i < cijene.Count; i++)
            {
                for (int j = 0; j < cijene[i].Count; j++)
                    tw.Write(cijene[i][j].ToString() + " ");
                tw.WriteLine();
            }
            tw.Close();
            MessageBox.Show("zavrsio");*/


            Close();
        }

        private void btnBrisiStanicu_Click(object sender, EventArgs e)
        {
            if (lvStanice.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste odabrali stanicu!");
                return;
            }

            if ((lvStanice.SelectedItems[0].Tag as Stanica).SifraStanice == linija.Stanice[0].SifraStanice)
            {
                MessageBox.Show("Ne možete obrisati početnu stanicu, kreirajte novu liniju!");
                return;
            }

            MessageBox.Show((lvStanice.SelectedItems[0].Tag as Stanica).Naziv);
        }
    }
}
