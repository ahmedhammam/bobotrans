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
        KolekcijaAutobusa a = KolekcijaAutobusa.Instanca;
        public PrikaziIzvjestaj()
        {
            InitializeComponent();
        }

        private void PrikaziIzvjestaj_Load(object sender, EventArgs e)
        {
            d.kreirajKonekciju();
            // DAL.DAL.AutobusDAO ad = new DAL.DAL.AutobusDAO();

            List<DAL.Entiteti.Autobus> autobusi = new List<DAL.Entiteti.Autobus>();
            autobusi = a.dajPoDatumu();
            foreach (DAL.Entiteti.Autobus au in autobusi)
                comboBox1.Items.Add(au.SifraAutobusa);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            int brojac = 0;
             DAL.DAL.IzvjestajDAO iz = new DAL.DAL.IzvjestajDAO();
             List<DAL.Entiteti.Izvjestaj> izvjestaji = new List<DAL.Entiteti.Izvjestaj>();
             iz = d.getDAO.getIzvjestajDAO();
             izvjestaji = iz.GetAll();
             foreach (DAL.Entiteti.Izvjestaj i in izvjestaji)
             {
                 if (Convert.ToInt32(i.SifraAutobusa) == Convert.ToInt32(comboBox1.Text))
                 {
                     dataGridView1.Rows.Add(i.DatumServisa, i.Tekst);
                 }
                 else brojac++;
             }
             if (brojac == izvjestaji.Count) MessageBox.Show("Nema izvještaja za traženi autobus!");
        }

    }
}
