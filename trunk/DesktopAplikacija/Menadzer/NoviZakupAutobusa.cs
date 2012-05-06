using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DesktopAplikacija.Entiteti;
using DAL.Entiteti;

namespace DesktopAplikacija.Menadzer
{
    public partial class NoviZakupAutobusa : Form
    {

        DAL.DAL d = DAL.DAL.Instanca;
        KolekcijaAutobusa ka = KolekcijaAutobusa.Instanca;
        KolekcijaZakupacaAutobusa kza = KolekcijaZakupacaAutobusa.Instanca;
        IznajmljivanjeAutobusa ia;

        public NoviZakupAutobusa(IznajmljivanjeAutobusa i)
        {
            ia = i;
            InitializeComponent();
        }

        private bool zauzetAutobus(DateTime poc, DateTime kraj,ZakupacAutobusa za)
        {
            return ((DateTime.Compare(poc, za.PocetakZakupa) <= 0 && DateTime.Compare(kraj, za.PocetakZakupa) >= 0) ||
                (DateTime.Compare(poc, za.KrajZakupa) <= 0 && DateTime.Compare(poc, za.PocetakZakupa) >= 0));
        }

        private List<Autobus> dajDostupneAutobuse(DateTime pocetak, DateTime kraj)
        {
            List<Autobus> dostupni = new List<Autobus>();
            bool slobodan;

            foreach (Autobus a in ka.Autobusi)
            {
                slobodan = true;
                if (!a.Slobodan) continue;

                foreach (ZakupacAutobusa za in kza.Zakupci)
                {
                    if (za.Autobus.SifraAutobusa == a.SifraAutobusa)
                    {
                        if (zauzetAutobus(pocetak, kraj, za))
                        {
                            slobodan = false;
                            break;
                        }
                    }
                }
                if (slobodan)
                {
                    dostupni.Add(a);
                }
            }

            return dostupni;
        }

        private void btnPrikazi_Click(object sender, EventArgs e)
        {

            if (DateTime.Compare(dtpPocetak.Value, dtpKraj.Value) >= 0 || DateTime.Compare(dtpPocetak.Value,DateTime.Now)<0)
            {
                MessageBox.Show("Neispravan unos datuma!");
                return;
            }

            DateTime pocetak = new DateTime(dtpPocetak.Value.Year, dtpPocetak.Value.Month, dtpPocetak.Value.Day);
            DateTime kraj = new DateTime(dtpKraj.Value.Year, dtpKraj.Value.Month, dtpKraj.Value.Day);

            List<Autobus> slobodni = dajDostupneAutobuse(pocetak,kraj);
            popuniAutobuse(slobodni);
        }

        
        private void popuniAutobuse(List<Autobus> l)
        {
            lvAutobusi.Items.Clear();
            for (int i = 0; i < l.Count; i++)
            {
                lvAutobusi.Items.Add(l[i].SifraAutobusa.ToString());
                lvAutobusi.Items[i].SubItems.Add(l[i].RegistracijskeTablice);
                lvAutobusi.Items[i].SubItems.Add(l[i].DatumServisa.ToString("dd.MM.yyyy"));
                lvAutobusi.Items[i].SubItems.Add(l[i].IstekRegistracije.ToString("dd.MM.yyyy"));
                lvAutobusi.Items[i].SubItems.Add(l[i].Slobodan ? "DA" : "NE");
                lvAutobusi.Items[i].SubItems.Add(l[i].BrojSjedista.ToString());
                lvAutobusi.Items[i].SubItems.Add(l[i].ImaKlimu ? "DA" : "NE");
                lvAutobusi.Items[i].SubItems.Add(l[i].ImaToalet ? "DA" : "NE");

                lvAutobusi.Items[i].Tag = l[i];
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (tbIme.Text == "")
            {
                MessageBox.Show("Niste unijeli ime");
                return;
            }
            if (lvAutobusi.SelectedItems.Count == 0)
            {
                MessageBox.Show("Niste selektirali autobus");
                return;
            }

            DialogResult dres = MessageBox.Show("Da li ste sigurni da želite spasiti dati zakup?", "Spašavanje?", MessageBoxButtons.YesNo);

            if (dres == DialogResult.Yes)
            {
                ZakupacAutobusa za = new ZakupacAutobusa(tbIme.Text, dtpPocetak.Value, dtpKraj.Value, Convert.ToInt32(nudCijena.Value), lvAutobusi.SelectedItems[0].Tag as Autobus);
                try
                {
                    DAL.DAL.ZakupacAutobusaDAO zad = d.getDAO.getZakupacAutobusaDAO();
                    d.kreirajKonekciju();
                    za.SifraKupca = zad.create(za);
                    ia.zakupljenAutobus(za);
                    MessageBox.Show("Spašeno!");
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                    return;
                }
            }
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
