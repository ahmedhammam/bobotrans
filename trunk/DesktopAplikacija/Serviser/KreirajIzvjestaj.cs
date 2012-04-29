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
        public KreirajIzvjestaj(string s)
        {
            InitializeComponent();
            pamti = 0;
            pamti1 = 0;
            sifra = s;
        }

        private void KreirajIzvjestaj_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            d.kreirajKonekciju();
            // DAL.DAL.AutobusDAO ad = new DAL.DAL.AutobusDAO();

            List<DAL.Entiteti.Autobus> autobusi = new List<DAL.Entiteti.Autobus>();
            autobusi = a.dajPoDatumu();
            foreach (DAL.Entiteti.Autobus au in autobusi)
                comboBox1.Items.Add(au.SifraAutobusa);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            d.kreirajKonekciju();
            DAL.DAL.IzvjestajDAO iz = new DAL.DAL.IzvjestajDAO();
            DAL.DAL.KorisnikDAO kor = new DAL.DAL.KorisnikDAO();
            List<DAL.Entiteti.Korisnik> korisnici = new List<DAL.Entiteti.Korisnik>();
            kor = d.getDAO.getKorisnikDAO();
            korisnici = kor.GetAll();
            foreach (DAL.Entiteti.Korisnik k in korisnici)
            {
                
                if (k.Password == sifra) 
                {
                    pamti = k.SifraKorisnika;
                    break;
                }
            }

            DAL.DAL.AutobusDAO ad = new DAL.DAL.AutobusDAO();
            List<DAL.Entiteti.Autobus> autobusi = new List<DAL.Entiteti.Autobus>();
            autobusi = a.dajPoDatumu();
            foreach (DAL.Entiteti.Autobus au in autobusi)
            {
                if (Convert.ToInt32(au.SifraAutobusa) == Convert.ToInt32(comboBox1.Text)) { pamti1 = au.SifraAutobusa; break; }

            }
            DAL.Entiteti.Izvjestaj i = new DAL.Entiteti.Izvjestaj(dateTimePicker1.Value, richTextBox1.Text, pamti,pamti1);
            DAL.DAL.IzvjestajDAO id1 = new DAL.DAL.IzvjestajDAO();
            i.SifraKreatora= id1.create(i);
            MessageBox.Show("Izvještaj kreiran!");
        }
    }
}
