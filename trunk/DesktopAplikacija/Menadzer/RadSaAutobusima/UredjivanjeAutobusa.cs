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
    public partial class UredjivanjeAutobusa : Form
    {
        private DAL.Entiteti.Autobus autobus;
        private DAL.DAL d = DAL.DAL.Instanca;
        private DAL.DAL.AutobusDAO ad;
        private DAL.DAL.IzvjestajDAO id;
        private List<DAL.Entiteti.Izvjestaj> izvjestaji = new List<DAL.Entiteti.Izvjestaj>();
        private Entiteti.KolekcijaKorisnika kk = Entiteti.KolekcijaKorisnika.Instanca;

        private PregledAutobusa pa;

        public UredjivanjeAutobusa(DAL.Entiteti.Autobus a, PregledAutobusa pregled)
        {
            pa = pregled;
            autobus = a;
            InitializeComponent();

            ad = d.getDAO.getAutobusDAO();

            popuniKomponente();
            
        }

        void popuniKomponente()
        {
            tbSifra.Text = autobus.SifraAutobusa.ToString();
            mtxtRegistracija.Text = autobus.RegistracijskeTablice;
            nudBrojSjedista.Value = autobus.BrojSjedista;
            dtpRegistracija.Value = autobus.IstekRegistracije;
            dtpServis.Value = autobus.DatumServisa;

            tbSlobodan.Text = autobus.Slobodan ? "DA" : "NE";

            cbKlima.Items.Add("NE");
            cbKlima.Items.Add("DA");

            cbToalet.Items.Add("NE");
            cbToalet.Items.Add("DA");

            cbKlima.SelectedIndex = Convert.ToInt32(autobus.ImaKlimu);
            cbToalet.SelectedIndex = Convert.ToInt32(autobus.ImaToalet);

            prikaziIzvjestaje();

        }

        private void ucitajIzvjestaje()
        {
            try
            {
                d.kreirajKonekciju();
                id = d.getDAO.getIzvjestajDAO();
                izvjestaji = id.getByExample("idAutobusa",autobus.SifraAutobusa.ToString());
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
                Close();
            }
        }

        private void prikaziIzvjestaje()
        {
            ucitajIzvjestaje();

            for (int i = 0; i < izvjestaji.Count; i++)
            {
                lvIzvjestaji.Items.Add(izvjestaji[i].SifraIzvjestaja.ToString());
                lvIzvjestaji.Items[i].SubItems.Add(kk.getNameById(izvjestaji[i].SifraKreatora));
                lvIzvjestaji.Items[i].SubItems.Add(izvjestaji[i].DatumServisa.ToString("dd.MM.yyyy"));
                lvIzvjestaji.Items[i].SubItems.Add(izvjestaji[i].Tekst);

                lvIzvjestaji.Items[i].Tag = izvjestaji[i];
            }

        }

        private bool stringToBool(string a)
        {
            return (a.ToUpper()=="DA")? true: false;
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnIzvjestaji_Click(object sender, EventArgs e)
        {
            try
            {
                DAL.DAL d = DAL.DAL.Instanca;
                d.kreirajKonekciju();

                DAL.DAL.IzvjestajDAO id = d.getDAO.getIzvjestajDAO();

                
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
        }

        private bool validiraj()
        {
            return ((cbKlima.Text.ToUpper() == "DA" || cbKlima.Text.ToUpper() == "NE") && (cbToalet.Text.ToUpper() == "DA" || cbToalet.Text.ToUpper() == "NE"));
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            if (!validiraj())
            {
                MessageBox.Show("Neispravan unos u jednom od polja!");
                return;
            }
            DialogResult dres = MessageBox.Show("Da li ste sigurni da želite promijeniti podatke za autobus?", "Update", MessageBoxButtons.YesNo);
            if (dres == DialogResult.Yes)
            {
                
                autobus.DatumServisa = dtpServis.Value;
                autobus.BrojSjedista = Convert.ToInt32(nudBrojSjedista.Value);
                autobus.ImaToalet = stringToBool(cbToalet.SelectedItem as string);
                autobus.ImaKlimu = stringToBool(cbKlima.SelectedItem as string);
                autobus.IstekRegistracije = dtpRegistracija.Value;
                autobus.RegistracijskeTablice = mtxtRegistracija.Text;

                try
                {
                    d.kreirajKonekciju();
                    ad.update(autobus);
                    pa.promjenjenAutobus(autobus);
                    MessageBox.Show("Podaci o autobusu su uspješno promjenjeni.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void listView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = (sender as ListView).Columns[e.ColumnIndex].Width;
        }

        private void lvIzvjestaji_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count == 0) return;

            rtbTekst.Text = (lv.SelectedItems[0].Tag as DAL.Entiteti.Izvjestaj).Tekst;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblServis_Click(object sender, EventArgs e)
        {

        }

        private void UredjivanjeAutobusa_Load(object sender, EventArgs e)
        {

        }
    }
}
