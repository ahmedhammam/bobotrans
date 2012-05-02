using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopAplikacija.Informisanje;
using DesktopAplikacija.Entiteti;

namespace DesktopAplikacija.RadnikZaSalterom
{
    public partial class aplikacijaSalter : Form
    {
        DAL.DAL d = DAL.DAL.Instanca;
        KolekcijaLinija kl = KolekcijaLinija.Instanca;
        DAL.DAL.VoznjaDAO vd;
        List<DAL.Entiteti.Voznja> voznje;
        public aplikacijaSalter()
        {
            InitializeComponent();
            try
            {
                d.kreirajKonekciju();
                vd = d.getDAO.getVoznjaDAO();
                voznje = vd.GetAll();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void najjeftinijiPutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NajjeftinijiPut np = new NajjeftinijiPut();
            np.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            d.kreirajKonekciju();
            DAL.Entiteti.Linija odabranaLinija = comboBox1.SelectedItem as DAL.Entiteti.Linija;
         foreach(DAL.Entiteti.Voznja v in odabranaLinija.Voznje)
          {
              listBox1.Items.Add(v);
          }
        }

        private void aplikacijaSalter_Load(object sender, EventArgs e)
        {
            d.kreirajKonekciju();
            foreach (DAL.Entiteti.Linija l in kl.Linije)
            {
                comboBox1.Items.Add(l);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            d.kreirajKonekciju();
            DAL.Entiteti.Voznja odabranaVoznja=(DAL.Entiteti.Voznja)listBox1.SelectedItem;
            int izabranaSifra = Convert.ToInt32(odabranaVoznja.Autobus.SifraAutobusa);
             PodaciOAutobusu p = new PodaciOAutobusu(izabranaSifra);
             p.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int brojac = 0;
            foreach (DAL.Entiteti.Linija al in kl.Linije)
            {
                if (al.NazivLinije != comboBox1.Text) brojac++;
            }
            if (comboBox1.Text=="")
            {
                MessageBox.Show("Niste selektovali liniju!");
            }
            else if (brojac == kl.Linije.Count)
            {
                MessageBox.Show("Upisana linija ne postoji !"); return;
            }
            else if(comboBox1.Text!="")
            {
                    DAL.Entiteti.Linija odabranaLinija = (DAL.Entiteti.Linija)comboBox1.SelectedItem;
                    CijeneNaLiniji cl = new CijeneNaLiniji(odabranaLinija);
                    cl.Show();
            }
        }
        private void informisanjeOLinijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformisanjeLinije il = new InformisanjeLinije();
            il.Show();
        }

        private void izvodIzRedaVožnjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IzvodIzRedaVoznje irv = new IzvodIzRedaVoznje();
            irv.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            NajjeftinijiPut np = new NajjeftinijiPut();
            np.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            InformisanjeLinije il = new InformisanjeLinije();
            il.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            IzvodIzRedaVoznje irv = new IzvodIzRedaVoznje();
            irv.Show();
        }

    }
}
