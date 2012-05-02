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
        DAL.Entiteti.Korisnik logovaniKorisnik;
        KolekcijaAutobusa ka = KolekcijaAutobusa.Instanca;

        public KreirajIzvjestaj(DAL.Entiteti.Korisnik k)
        {
            InitializeComponent();
            logovaniKorisnik = k;
        }

        private void KreirajIzvjestaj_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MaxDate = DateTime.Now;
            dateTimePicker1.MinDate = DateTime.Now;
            try
            {
                d.kreirajKonekciju();
                foreach (DAL.Entiteti.Autobus au in ka.Autobusi)
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                d.kreirajKonekciju();
                DAL.DAL.IzvjestajDAO iz = new DAL.DAL.IzvjestajDAO();
                DAL.DAL.AutobusDAO ad = new DAL.DAL.AutobusDAO();
                if (comboBox1.Text == "")
                {
                    MessageBox.Show("Niste selektovali autobus!");
                }
                else
                {
                    long odabraniAutobus = Convert.ToInt32(comboBox1.Text);
                    DAL.Entiteti.Autobus au = ka.dajPoSifri(odabraniAutobus);
                    if (au == null)
                        throw new Exception("Ne postoji autobus sa unesenom sifrom!");
                    DAL.Entiteti.Izvjestaj i = new DAL.Entiteti.Izvjestaj(dateTimePicker1.Value, richTextBox1.Text, logovaniKorisnik.SifraKorisnika, au.SifraAutobusa);
                    DAL.DAL.IzvjestajDAO id1 = d.getDAO.getIzvjestajDAO();
                    DialogResult dres;
                    dres = MessageBox.Show("Jeste li sigurni da želite pohraniti izvještaj?", "provjera", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dres == System.Windows.Forms.DialogResult.Yes)
                    {
                        i.SifraIzvjestaja = id1.create(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}