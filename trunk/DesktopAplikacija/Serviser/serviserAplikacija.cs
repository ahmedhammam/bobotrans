using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopAplikacija.Serviser.Entiteti;
using DesktopAplikacija.Poruke;
namespace DesktopAplikacija.Serviser
{
    public partial class serviserAplikacija : Form
    {
       
                DAL.DAL d = DAL.DAL.Instanca;
 
               
       
        public serviserAplikacija()
        {
            InitializeComponent();
        }

        private void serviserAplikacija_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            d.kreirajKonekciju();
            DAL.DAL.AutobusDAO ad = new DAL.DAL.AutobusDAO();
            KolekcijaAutobusa a = KolekcijaAutobusa.Instanca;
            List<DAL.Entiteti.Autobus> autobusi = new List<DAL.Entiteti.Autobus>();
            if (comboBox1.Text=="DatumIstekaRegistracije")
            {
                autobusi = a.dajPoIsteku();
                foreach (DAL.Entiteti.Autobus au in autobusi)
                {
                    dataGridView1.Rows.Add(au.SifraAutobusa, au.RegistracijskeTablice, au.IstekRegistracije, au.BrojSjedista, au.DatumServisa);
                }
            }
            else if (comboBox1.Text=="DatumServisa")
            {
                autobusi = a.dajPoDatumu();
                foreach (DAL.Entiteti.Autobus au in autobusi)
                {
                    dataGridView1.Rows.Add(au.SifraAutobusa, au.RegistracijskeTablice, au.IstekRegistracije, au.BrojSjedista, au.DatumServisa);
                }
            }
         
           d.terminirajKonekciju();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void izađiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            serviserAplikacija:Close();
        }

        private void Izađi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kreirajIzvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KreirajIzvjestaj k = new KreirajIzvjestaj();
            k.Show();
        }

        private void prikažiIzvještajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziIzvjestaj p = new PrikaziIzvjestaj();
            p.Show();
        }

        private void izmijeniPodatkeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzmijeniPodatke i=new IzmijeniPodatke();
            i.Show();
        }

        private void prikažiPorukeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrikaziPoruke p = new PrikaziPoruke();
            p.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            KreirajIzvjestaj k = new KreirajIzvjestaj();
            k.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PrikaziIzvjestaj p = new PrikaziIzvjestaj();
            p.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            IzmijeniPodatke i = new IzmijeniPodatke();
            i.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            PrikaziPoruke p = new PrikaziPoruke();
            p.Show();
        }

        private void prikažiPorukeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
