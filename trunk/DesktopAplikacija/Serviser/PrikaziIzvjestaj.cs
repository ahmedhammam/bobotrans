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
    public partial class PrikaziIzvjestaj : Form
    {
        DAL.DAL d = DAL.DAL.Instanca;
        KolekcijaAutobusa ak = KolekcijaAutobusa.Instanca;
        DAL.DAL.IzvjestajDAO iz;
        List<DAL.Entiteti.Izvjestaj> izvjestaji ;
        public PrikaziIzvjestaj()
        {
            InitializeComponent();
           try
            {
                iz = new DAL.DAL.IzvjestajDAO();
                izvjestaji = new List<DAL.Entiteti.Izvjestaj>();
                iz = d.getDAO.getIzvjestajDAO();
                izvjestaji = iz.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void PrikaziIzvjestaj_Load(object sender, EventArgs e)
        {
            try { 
            d.kreirajKonekciju();
            foreach (DAL.Entiteti.Autobus au in ak.Autobusi)
                comboBox1.Items.Add(au.SifraAutobusa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DAL.Entiteti.Izvjestaj i = new DAL.Entiteti.Izvjestaj();
            i = (DAL.Entiteti.Izvjestaj)listBox1.SelectedItem;
            tekstIzvjestaja t = new tekstIzvjestaja(Convert.ToString(i.Tekst));
            t.Show();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            int brojac = 0;
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Niste selektovali autobus!");
            }
            else
            {
                List<DAL.Entiteti.Izvjestaj> nova = new List<DAL.Entiteti.Izvjestaj>();
                foreach (DAL.Entiteti.Izvjestaj iz in izvjestaji)
                {
                    if (Convert.ToInt32(iz.SifraAutobusa) == Convert.ToInt32(comboBox1.Text)) nova.Add(iz);
                }
                for (int i = 0; i < nova.Count; i++)
                {
                    for (int j = i + 1; j < nova.Count; j++)
                    {
                        if (nova[j].DatumServisa < nova[i].DatumServisa)
                        {
                            DAL.Entiteti.Izvjestaj novi = nova[i];
                            nova[i] = nova[j];
                            nova[j] = novi;

                        }
                    }
                }
                DateTime dt;
                foreach (DAL.Entiteti.Izvjestaj i in nova)
                {
                    if (Convert.ToInt32(i.SifraAutobusa) == Convert.ToInt32(comboBox1.Text))
                    {
                        dt = i.DatumServisa;
                        listBox1.Items.Add(i);
                    }
                    else brojac++;
                }
                if (brojac == izvjestaji.Count) MessageBox.Show("Nema izvještaja za traženi autobus!");
            }
        }
    }
}
