using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopAplikacija.Serviser.Entiteti;

namespace DesktopAplikacija.Serviser
{
    public partial class KreirajIzvjestaj : Form
    {
        DAL.DAL d = DAL.DAL.Instanca;
        string sifra;
        long pamti;
        long pamti1;
        KolekcijaAutobusa a = KolekcijaAutobusa.Instanca;
        List<DAL.Entiteti.Korisnik> korisnici;
        DAL.DAL.KorisnikDAO kor;
        List<DAL.Entiteti.Autobus> autobusi;
        public KreirajIzvjestaj(string s)
        {
            InitializeComponent();
            pamti = 0;
            pamti1 = 0;
            sifra = s;
            try
            {
                kor = new DAL.DAL.KorisnikDAO();
                kor = d.getDAO.getKorisnikDAO();
                korisnici = new List<DAL.Entiteti.Korisnik>();
                korisnici = kor.GetAll();
                autobusi = new List<DAL.Entiteti.Autobus>();
                autobusi = a.dajPoDatumu();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void KreirajIzvjestaj_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;
            try
            {
                d.kreirajKonekciju();
                // DAL.DAL.AutobusDAO ad = new DAL.DAL.AutobusDAO();
                foreach (DAL.Entiteti.Autobus au in autobusi)
                    comboBox1.Items.Add(au.SifraAutobusa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                d.kreirajKonekciju();
                DAL.DAL.IzvjestajDAO iz = new DAL.DAL.IzvjestajDAO();
                foreach (DAL.Entiteti.Korisnik k in korisnici)
                {

                    if (k.Password == sifra)
                    {
                        pamti = k.SifraKorisnika;
                        break;
                    }
                }

                DAL.DAL.AutobusDAO ad = new DAL.DAL.AutobusDAO();
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Niste selektovali autobus!");
                }
                else
                {
                    foreach (DAL.Entiteti.Autobus au in autobusi)
                    {
                        if (Convert.ToInt32(au.SifraAutobusa) == Convert.ToInt32(comboBox1.Text)) { pamti1 = au.SifraAutobusa; break; }

                    }
                    DAL.Entiteti.Izvjestaj i = new DAL.Entiteti.Izvjestaj(dateTimePicker1.Value, richTextBox1.Text, pamti, pamti1);
                    DAL.DAL.IzvjestajDAO id1 = new DAL.DAL.IzvjestajDAO();
                    i.SifraKreatora = id1.create(i);
                    DialogResult dres;
                    dres = MessageBox.Show("Jeste li sigurni da želite pohraniti izvještaj?", "provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dres == System.Windows.Forms.DialogResult.Yes)
                        MessageBox.Show("Izvještaj je pohranjen!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}