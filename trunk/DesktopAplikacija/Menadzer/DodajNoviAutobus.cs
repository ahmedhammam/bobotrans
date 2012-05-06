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
    public partial class DodajNoviAutobus : Form
    {
        private DAL.DAL d = DAL.DAL.Instanca;
        private DAL.DAL.AutobusDAO ad;

        private PregledAutobusa pa;

        Entiteti.KolekcijaAutobusa ka = Entiteti.KolekcijaAutobusa.Instanca;

        public DodajNoviAutobus(PregledAutobusa pre)
        {
            pa = pre;
            ad = d.getDAO.getAutobusDAO();
            InitializeComponent();
            popuniKomponente();
        }

        void popuniKomponente()
        {
            tbSlobodan.Text = "DA";

            cbKlima.Items.Add("NE");
            cbKlima.Items.Add("DA");

            cbToalet.Items.Add("NE");
            cbToalet.Items.Add("DA");

            cbKlima.SelectedIndex = 0;
            cbToalet.SelectedIndex = 0;

        }

        private bool validiraj()
        {

            return (((cbKlima.SelectedItem as string).ToUpper() == "DA" || (cbKlima.SelectedItem as string).ToUpper() == "NE") && 
                ((cbToalet.SelectedItem as string).ToUpper() == "DA" || (cbToalet.SelectedItem as string).ToUpper() == "NE"));
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool stringToBool(string a)
        {
            return (a.ToUpper() == "DA") ? true : false;
        }


        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (!validiraj())
            {
                MessageBox.Show("Neispravan unos u jednom od polja!");
                return;
            }

            DAL.Entiteti.Autobus a = new DAL.Entiteti.Autobus(Convert.ToInt32(nudBrojSjedista.Value),mtxtRegistracija.Text,stringToBool((cbToalet.SelectedItem as string).ToUpper()),true,
                stringToBool((cbKlima.SelectedItem as string).ToUpper()), dtpRegistracija.Value,dtpServis.Value);

            DialogResult dres = MessageBox.Show("Da li ste sigurni da želite spasiti novi autobus?", "Update", MessageBoxButtons.YesNo);
            if (dres == DialogResult.Yes)
            {
                try
                {
                    d.kreirajKonekciju();
                    a.SifraAutobusa = ad.create(a);
                    tbSifra.Text = a.SifraAutobusa.ToString();
                    ka.Autobusi.Add(a);
                    pa.noviAutobus(a);
                    MessageBox.Show("Uspješno je dodan novi autobus!");
                    d.terminirajKonekciju();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
            }
        }
    }
}
