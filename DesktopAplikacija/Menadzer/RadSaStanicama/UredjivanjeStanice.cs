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
    public partial class UredjivanjeStanice : Form
    {

        private Entiteti.KolekcijaStanica ks = Entiteti.KolekcijaStanica.Instanca;
        private bool novaStanica;
        private DAL.Entiteti.Stanica odabranaStanica;
        private PregledStanica pozvanOd;

        public UredjivanjeStanice(PregledStanica us,bool nova=true, DAL.Entiteti.Stanica s=null)
        {
            InitializeComponent();
            novaStanica = nova;
            pozvanOd = us;
            if (!nova)
            {
                odabranaStanica = s;
                tbNaziv.Text = s.Naziv;
                tbMjesto.Text = s.Mjesto;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSpasi_Click(object sender, EventArgs e)
        {
            DialogResult dres = MessageBox.Show("Da li ste sigurni da želite spasiti stanicu?", "Spasiti?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dres == DialogResult.Yes)
            {
                try
                {
                    if (novaStanica)
                    {
                        DAL.Entiteti.Stanica stanica = new DAL.Entiteti.Stanica(tbNaziv.Text, tbMjesto.Text);
                        stanica.SifraStanice = ks.kreirajStanicu(stanica);
                        pozvanOd.dodanaStanica(stanica);
                    }
                    else
                    {
                        odabranaStanica.Naziv = tbNaziv.Text;
                        odabranaStanica.Mjesto = tbMjesto.Text;
                        ks.updateStanice(odabranaStanica);
                        pozvanOd.promjenjenaStanica();
                    }

                    MessageBox.Show("Promjene su uspješno izvršene!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
    }
}
