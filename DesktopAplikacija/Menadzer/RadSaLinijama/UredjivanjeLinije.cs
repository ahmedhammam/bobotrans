using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DAL.Entiteti;
using DesktopAplikacija.Menadzer;
using System.Threading;

namespace DesktopAplikacija.Menadzer
{
    public partial class UredjivanjeLinije : Form
    {
        public delegate void AddListItem();
        public AddListItem myDelegate;
     
        private Thread myThread;
        public delegate void AddListItem1();
        public AddListItem1 myDelegate1;

        private Thread myThread1;
        private Linija linija;
        private PregledLinija pozvanOd;
        private DesktopAplikacija.Entiteti.KolekcijaStanica ks = DesktopAplikacija.Entiteti.KolekcijaStanica.Instanca;
        private List<Stanica> moguceStanice = new List<Stanica>();

        private int trajanjeDoDolaska = 0, trajanjeDoPolaska = 0;
        private int redniBroj = 0;
        private bool dodanaStanica = false,obrisanaStanica = false;
        private DesktopAplikacija.Entiteti.KolekcijaLinija kl = DesktopAplikacija.Entiteti.KolekcijaLinija.Instanca;
        private Stanica odabranaStanica;

        public UredjivanjeLinije(Linija l, PregledLinija pl)
        {
            InitializeComponent();
            linija = l;
            pozvanOd = pl;
            myDelegate = new AddListItem(AddListItemMethod);
            myDelegate1 = new AddListItem1(AddListItemMethod1);
            popuniKomponente();
            
        }


        void popuniKomponente()
        {
            lblSifra.Text = linija.SifraLinije.ToString();
            tbNaziv.Text = linija.NazivLinije;
            btnDodajStanicu.Enabled = true;
            btnBrisiStanicu.Enabled = true;
            dodanaStanica = false;
            obrisanaStanica = false;

            popuniStanice();
            popuniCijene();
            
        }

        void popuniStanice()
        {
            lvStanice.Items.Clear();
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
            cbStanice.Items.Clear();
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
            cbRedniBroj.Items.Clear();
            for (int i = 1; i <= linija.Stanice.Count;i++ )
                cbRedniBroj.Items.Add(i);
            if (cbRedniBroj.Items.Count > 0) 
                cbRedniBroj.SelectedIndex = 0;
        }

        void popuniCijene()
        {
            dgvCijene.Rows.Clear();
            DataGridViewCellStyle crveno = new DataGridViewCellStyle();
            crveno.BackColor = System.Drawing.Color.Red;
            if (dgvCijene.ColumnCount == 0)
            {
                for (int i = 1; i < linija.Stanice.Count; i++)
                {
                    dgvCijene.Columns.Add("col" + i.ToString(), linija.Stanice[i].Naziv);
                    dgvCijene.Columns[i - 1].SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
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
            DialogResult dres = MessageBox.Show("Da li ste sigurni da želite izaći bez spašavanja promjena?", "Izaći?", MessageBoxButtons.YesNo);
            if (dres == DialogResult.Yes)
            {
                Close();
            }
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

            dgvCijene.Columns.Insert(redniBroj-1, dgvc);

            dgvCijene.Rows.Insert(redniBroj);
            dgvCijene.Rows[redniBroj].HeaderCell.Value = stanica.Naziv + ", " + stanica.Mjesto;

            DataGridViewCellStyle crveno = new DataGridViewCellStyle();
            crveno.BackColor = System.Drawing.Color.Red;
            

            for (int i = 0; i < redniBroj-1; i++)
            {
                dgvCijene.Rows[redniBroj].Cells[i] .Style = crveno;
                dgvCijene.Rows[redniBroj].Cells[i].ReadOnly = true;
            }
            for (int i = redniBroj; i < dgvCijene.Rows.Count; i++)
            {
                dgvCijene.Rows[i].Cells[redniBroj-1].Style = crveno;
                dgvCijene.Rows[i].Cells[redniBroj-1].ReadOnly = true;
            }
        }

        public void AddListItemMethod()
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
            odabranaStanica = moguceStanice[cbStanice.SelectedIndex];

            lvStanice.Items.Insert(redniBroj, odabranaStanica.SifraStanice.ToString());
            lvStanice.Items[redniBroj].SubItems.Add(odabranaStanica.Naziv);
            lvStanice.Items[redniBroj].SubItems.Add(odabranaStanica.Mjesto);
            lvStanice.Items[redniBroj].SubItems.Add(trajanjeDoDolaska.ToString());
            lvStanice.Items[redniBroj].SubItems.Add(trajanjeDoPolaska.ToString());
            updateDgvCijene(redniBroj, trajanjeDoPolaska, trajanjeDoDolaska, odabranaStanica);
            dodanaStanica = true;
            btnDodajStanicu.Enabled = false;
            btnBrisiStanicu.Enabled = false;
        }

        private void ThreadFunction()
        {
            MyThreadClass myThreadClassObject = new MyThreadClass(this);
            myThreadClassObject.Run();
        }

        public void AddListItemMethod1()
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
            odabranaStanica = moguceStanice[cbStanice.SelectedIndex];

            updateDgvCijene(redniBroj, trajanjeDoPolaska, trajanjeDoDolaska, odabranaStanica);
            dodanaStanica = true;
            btnDodajStanicu.Enabled = false;
            btnBrisiStanicu.Enabled = false;
        }

        private void ThreadFunction1()
        {
            MyThreadClass myThreadClassObject = new MyThreadClass(this);
            myThreadClassObject.Run();
        }
        private void btnDodajStanicu_Click(object sender, EventArgs e)
        {
            myThread = new Thread(new ThreadStart(ThreadFunction));
            myThread.Start();
            myThread1 = new Thread(new ThreadStart(ThreadFunction1));
            myThread1.Start();
        }

        private bool sadrziSlovo(string s)
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
            if (dodanaStanica)
                brojStanica++;
            else if (obrisanaStanica)
                brojStanica--;


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

            DialogResult dres =  MessageBox.Show("Da li ste sigurni da želite spasiti unesene promjene?", "Spasiti?", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dres == DialogResult.Yes)
            {
                linija.NazivLinije = tbNaziv.Text;
                linija.Cijene = cijene;


                if (dodanaStanica)
                {
                    linija.Stanice.Insert(redniBroj, odabranaStanica);
                    linija.TrajanjeDoDolaska.Insert(redniBroj, trajanjeDoDolaska);
                    linija.TrajanjeDoPolaska.Insert(redniBroj, trajanjeDoPolaska);
                }

                try
                {
                    kl.updateujLiniju(linija);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    return;
                }

                MessageBox.Show("Promjene su uspješno spašene");
                popuniKomponente();
                
            }
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

            DialogResult dres = MessageBox.Show("Da li ste sigurni da želite izbrisati označenu stanicu iz linije (time brišete i sve cijene)?","Brisati?",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (dres == DialogResult.Yes)
            {
                obrisanaStanica = true;
                Stanica oznacenaStanica = lvStanice.SelectedItems[0].Tag as Stanica;
                int redniBroj = linija.sadrziStanicu(oznacenaStanica);
                lvStanice.Items.Remove(lvStanice.SelectedItems[0]);

                dgvCijene.Rows.RemoveAt(redniBroj);
                dgvCijene.Columns.RemoveAt(redniBroj - 1);


                try
                {
                    linija.Cijene = validirajUneseneCijene();
                    linija.Stanice.RemoveAt(redniBroj);
                    linija.TrajanjeDoDolaska.RemoveAt(redniBroj);
                    linija.TrajanjeDoPolaska.RemoveAt(redniBroj);
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    return;
                }

                kl.updateujLiniju(linija);

                MessageBox.Show("Stanica uspješno izbrisana!");
                popuniKomponente();
            }

            //MessageBox.Show((lvStanice.SelectedItems[0].Tag as Stanica).Naziv);
        }

        private void btnPrikaziRasporede_Click(object sender, EventArgs e)
        {
            UredjivanjeRasporedaVoznje urv = new UredjivanjeRasporedaVoznje(linija);
            urv.Show();
        }

    }
}


public class MyThreadClass
{
    UredjivanjeLinije myFormControl1;
    public MyThreadClass(UredjivanjeLinije myForm)
    {
        myFormControl1 = myForm;
    }

    public void Run()
    {
        
        myFormControl1.Invoke(myFormControl1.myDelegate);
        myFormControl1.Invoke(myFormControl1.myDelegate);
    }
}