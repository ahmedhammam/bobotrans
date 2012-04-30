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
    public partial class serviserAplikacija : Form
    {
        DAL.DAL d = DAL.DAL.Instanca;
        string s;
        int pamti;
        KolekcijaAutobusa a = KolekcijaAutobusa.Instanca;
        public serviserAplikacija()
        {
            InitializeComponent();
        }
        public serviserAplikacija(string sifra)
        {
            InitializeComponent();
            s = sifra;
            pamti = 0;
        }
   
        private void izađiToolStripMenuItem_Click(object sender, EventArgs e)
        {
        serviserAplikacija: Close();
        }

        private void Izađi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kreirajIzvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreirajIzvjestaj k = new KreirajIzvjestaj(s);
            k.Show();
        }

        private void prikažiIzvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziIzvjestaj p = new PrikaziIzvjestaj();
            p.Show();
        }

        private void prikažiPorukeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziPoruke p = new PrikaziPoruke();
            p.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            KreirajIzvjestaj k = new KreirajIzvjestaj(s);
            k.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PrikaziIzvjestaj p = new PrikaziIzvjestaj();
            p.Show();
        }


        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            PrikaziPoruke p = new PrikaziPoruke();
            p.Show();
        }

        private void serviserAplikacija_Load(object sender, EventArgs e)
        {
            d.kreirajKonekciju();
            // DAL.DAL.AutobusDAO ad = new DAL.DAL.AutobusDAO();
           
            List<DAL.Entiteti.Autobus> autobusi = new List<DAL.Entiteti.Autobus>();
            autobusi = a.dajPoDatumu();
            foreach (DAL.Entiteti.Autobus au in autobusi)
                toolStripComboBox1.Items.Add(au.SifraAutobusa);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.Text != "")
            {
                int sifra = Convert.ToInt32(toolStripComboBox1.Text);
                IzmijeniPodatke i = new IzmijeniPodatke(sifra);
                i.Show();
            }
        }

        private void toolStripButton5_Click_1(object sender, EventArgs e)
        {
                DAL.DAL.AutobusDAO ad = new DAL.DAL.AutobusDAO();
                List<DAL.Entiteti.Autobus> autobusi = new List<DAL.Entiteti.Autobus>();
                autobusi = a.dajPoDatumu();
                int brojac = 0;
                foreach (DAL.Entiteti.Autobus au in autobusi)
                {
                    if (Convert.ToInt32(au.SifraAutobusa) == Convert.ToInt32(toolStripComboBox1.Text)) { pamti = Convert.ToInt32(toolStripComboBox1.Text); break; }
                    else brojac++;
                }
                if (brojac == autobusi.Count) MessageBox.Show("Niste selektovali autobus!");
                IzmijeniPodatke i = new IzmijeniPodatke(pamti);
                i.Show();
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

             DAL.DAL.AutobusDAO ad = new DAL.DAL.AutobusDAO();

            List<DAL.Entiteti.Autobus> autobusi = new List<DAL.Entiteti.Autobus>();
            if (comboBox1.Text == "Datum isteka registracije")
            {
                autobusi = a.dajPoIsteku();
                foreach (DAL.Entiteti.Autobus au in autobusi)
                {
                    
                    dataGridView1.Rows.Add(au.SifraAutobusa, au.RegistracijskeTablice, au.IstekRegistracije, au.BrojSjedista, au.DatumServisa);
                }
            }
            else if (comboBox1.Text == "Datum servisa")
            {
                autobusi = a.dajPoDatumu();
                foreach (DAL.Entiteti.Autobus au in autobusi)
                {
                    dataGridView1.Rows.Add(au.SifraAutobusa, au.RegistracijskeTablice, au.IstekRegistracije, au.BrojSjedista, au.DatumServisa);
                }
            }

            d.terminirajKonekciju();
        }
    }

}