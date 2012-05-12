using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopAplikacija.Menadzer
{
    public partial class DodajNovuLiniju : Form
    {
        private PregledLinija pozvanOd;

        private Entiteti.KolekcijaLinija kl = Entiteti.KolekcijaLinija.Instanca;
        private Entiteti.KolekcijaStanica ks = Entiteti.KolekcijaStanica.Instanca;
        private List<DAL.Entiteti.Stanica> stanice = new List<DAL.Entiteti.Stanica>(),moguceStanice;
        private List<List<double>> cijene = new List<List<double>>();
        private List<DAL.Entiteti.RasporedVoznje> rasporediVoznje = new List<DAL.Entiteti.RasporedVoznje>();
        private DataGridViewCellStyle crveno = new DataGridViewCellStyle(), obicno = new DataGridViewCellStyle();

        public DodajNovuLiniju(PregledLinija pl)
        {
            InitializeComponent();

            pozvanOd = pl;
            moguceStanice = ks.Stanice;
            popuniComboBoxStanicama();
            crveno.BackColor = System.Drawing.Color.Red;
        }

        private bool nijeDodanaStanica(DAL.Entiteti.Stanica s)
        {
            foreach (DataGridViewRow dgvr in dgvStanice.Rows)
                if ((dgvr.Tag as DAL.Entiteti.Stanica).SifraStanice == s.SifraStanice)
                    return false;
            return true;
        }

        private void popuniComboBoxStanicama()
        {
            cbStanice.Items.Clear();
            for (int i = 0; i < moguceStanice.Count; i++)
            {
                if (nijeDodanaStanica(moguceStanice[i]))
                {
                    cbStanice.Items.Add(moguceStanice[i].Naziv + " - " + moguceStanice[i].Mjesto);
                }

            }

            cbStanice.SelectedIndex = 0;
        }
        private void popuniRedneBrojeve()
        {
            cbRednibroj.Items.Clear();
            for (int i = 1; i <= dgvStanice.RowCount + 1; i++)
                cbRednibroj.Items.Add(i.ToString());
        }

        private void rbPolozaj_CheckedChanged(object sender, EventArgs e)
        {
            cbRednibroj.Enabled = !cbRednibroj.Enabled;
            if (cbRednibroj.Enabled)
            {
                popuniRedneBrojeve();
            }
        }

        private int mjestoDodavanjaStanice()
        {
            if (rbKraj.Checked) return dgvStanice.RowCount;
            if (rbPocetak.Checked) return 0;

            return cbRednibroj.SelectedIndex;
        }

        private void btnDodajStanicu_Click(object sender, EventArgs e)
        {
            int mjestoDodavanja = mjestoDodavanjaStanice();

            DAL.Entiteti.Stanica s = ks.Stanice[cbStanice.SelectedIndex];


            stanice.Insert(mjestoDodavanja,s);
            moguceStanice.RemoveAt(cbStanice.SelectedIndex);
            dgvStanice.Rows.Insert(mjestoDodavanja,1);
            dgvStanice.Rows[mjestoDodavanja].Cells[0].Value = s.SifraStanice;
            dgvStanice.Rows[mjestoDodavanja].Cells[1].Value = s.Naziv;
            dgvStanice.Rows[mjestoDodavanja].Tag = s;
            popuniComboBoxStanicama();
            popuniRedneBrojeve();
            rbKraj.Checked = true;

            dgvStanice.Rows[0].ReadOnly = true;
            dgvStanice.Rows[dgvStanice.RowCount - 1].Cells[3].ReadOnly = true;
            dgvStanice.Rows[dgvStanice.RowCount - 1].Cells[3].Style = crveno;

            if (dgvStanice.RowCount > 1)
            {
                dgvStanice.Rows[1].ReadOnly = false;
                dgvStanice.Rows[dgvStanice.RowCount - 2].Cells[3].ReadOnly = false;
                dgvStanice.Rows[dgvStanice.RowCount - 2].Cells[3].Style = obicno;
            }

            dgvStanice.Rows[dgvStanice.RowCount - 1].Cells[3].Value = dgvStanice.Rows[dgvStanice.RowCount - 1].Cells[2].Value;

            dgvStanice.Rows[0].Cells[2].Value = 0;
            dgvStanice.Rows[0].Cells[3].Value = 0;

            if (stanice.Count > 1)
            {
                btnUnosCijena.Enabled = true;
                btnRasporedi.Enabled = true;
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            DialogResult dres = MessageBox.Show("Da li ste sigurni da želite izaći bez spašavanja promjena?", "Izaći?", MessageBoxButtons.YesNo);
            if (dres == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnUnosCijena_Click(object sender, EventArgs e)
        {
            UnosCijena uc = new UnosCijena(stanice, this,cijene);
            uc.Show();
        }

        public void uneseneCijene(List<List<double>> c)
        {
            cijene = c;
        }

        public void uneseniRasporedi(List<DAL.Entiteti.RasporedVoznje> rv)
        {
            rasporediVoznje = rv;
        }

        private void btnRasporedi_Click(object sender, EventArgs e)
        {
            DodajRasporedVoznje drv = new DodajRasporedVoznje(rasporediVoznje,this);
            drv.Show();
        }

        private void btnBrisiStanice_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in dgvStanice.SelectedRows)
            {
                stanice.Remove(dgvr.Tag as DAL.Entiteti.Stanica);
                moguceStanice.Add(dgvr.Tag as DAL.Entiteti.Stanica);
                dgvStanice.Rows.Remove(dgvr);
                popuniComboBoxStanicama();
                popuniRedneBrojeve();
            }

            dgvStanice.Rows[0].ReadOnly = true;
            dgvStanice.Rows[0].Cells[2].Value = 0;
            dgvStanice.Rows[0].Cells[3].Value = 0;

            dgvStanice.Rows[dgvStanice.RowCount - 1].Cells[3].ReadOnly = true;
            dgvStanice.Rows[dgvStanice.RowCount - 1].Cells[3].Style = crveno;
            dgvStanice.Rows[dgvStanice.RowCount - 1].Cells[3].Value = dgvStanice.Rows[dgvStanice.RowCount - 1].Cells[2].Value;
            

            if (stanice.Count < 2)
            {
                btnUnosCijena.Enabled = false;
                btnRasporedi.Enabled = false;
            }
        }

        private bool sadrziSlovo(string s)
        {
            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                    return true;
            }
            return false;
        }


        bool validirajBroj(int red,int kolona)
        {
            if (dgvStanice.Rows[red].Cells[kolona].Value==null)
                return false;

            string broj = dgvStanice.Rows[red].Cells[kolona].Value.ToString();
            
            if (sadrziSlovo(broj))
                return false;
            return true;
        }

        private void validirajTrajanja(out List<int> dolazak,out List<int> polazak)
        {
            dolazak = new List<int>(){0};
            polazak = new List<int>(){0};
            for (int i = 1; i < dgvStanice.RowCount; i++)
            {
                if (!validirajBroj(i, 2))
                    throw new Exception("Netacan unos u "+i.ToString()+"-om redu za trajanje do dolaska!");
                if(!validirajBroj(i,3))
                    throw new Exception("Netacan unos u " + i.ToString() + "-om redu za trajanje do dolaska!");

                dolazak.Add(Convert.ToInt32(dgvStanice.Rows[i].Cells[2].Value));
                polazak.Add(Convert.ToInt32(dgvStanice.Rows[i].Cells[3].Value));
            }

            for (int i = 1; i < dolazak.Count; i++)
            {
                if(i==dolazak.Count-1)
                {
                    if (dolazak[i] <= polazak[i - 1])
                        throw new Exception("Vremenski tok trajanja do dolaska i polaska nije uredu oko " + i.ToString() + "-tog reda!");
                    else break;
                }

                if (dolazak[i] >= polazak[i] || dolazak[i] <= polazak[i - 1])
                    throw new Exception("Vremenski tok trajanja do dolaska i polaska nije uredu oko "+i.ToString()+"-tog reda!");
            }

        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {

            if (stanice.Count < 1 || cijene.Count == 0 || rasporediVoznje.Count == 0)
            {
                MessageBox.Show("Niste unijeli sve potrebne vrijednosti da opišete liniju!");
                return;
            }

            dgvStanice.Rows[dgvStanice.RowCount - 1].Cells[3].Value = dgvStanice.Rows[dgvStanice.RowCount - 1].Cells[2].Value;

            List<int> trajanjeDoDolaska,trajanjeDoPolaska;
            try
            {
                validirajTrajanja(out trajanjeDoDolaska,out trajanjeDoPolaska);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            DAL.Entiteti.Linija novaLinija = new DAL.Entiteti.Linija(tbNaziv.Text, stanice, trajanjeDoDolaska, trajanjeDoPolaska, cijene, new List<DAL.Entiteti.Voznja>(), rasporediVoznje);


            try
            {
                novaLinija.SifraLinije = kl.dodajLiniju(novaLinija);
                pozvanOd.promjenjenaLinija();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            MessageBox.Show("Promjene su uspješno spašene u bazu!");
            Close();
            
        }
    }
}
