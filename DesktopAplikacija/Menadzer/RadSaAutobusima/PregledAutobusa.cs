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
    public partial class PregledAutobusa : Form
    {

        private Entiteti.KolekcijaAutobusa ka = Entiteti.KolekcijaAutobusa.Instanca;
        private DAL.DAL d = DAL.DAL.Instanca;
        private DAL.DAL.AutobusDAO ad;

        public PregledAutobusa()
        {
            InitializeComponent();
            popuniAutobuse();
            
        }

        private void popuniAutobuse()
        {
            lvAutobusi.Items.Clear();
            for (int i = 0; i < ka.Autobusi.Count; i++)
            {
                lvAutobusi.Items.Add(ka.Autobusi[i].SifraAutobusa.ToString());
                lvAutobusi.Items[i].SubItems.Add(ka.Autobusi[i].RegistracijskeTablice);
                lvAutobusi.Items[i].SubItems.Add(ka.Autobusi[i].DatumServisa.ToString("dd.MM.yyyy"));
                lvAutobusi.Items[i].SubItems.Add(ka.Autobusi[i].IstekRegistracije.ToString("dd.MM.yyyy"));
                lvAutobusi.Items[i].SubItems.Add(ka.Autobusi[i].Slobodan?"DA":"NE");
                lvAutobusi.Items[i].SubItems.Add(ka.Autobusi[i].BrojSjedista.ToString());
                lvAutobusi.Items[i].SubItems.Add(ka.Autobusi[i].ImaKlimu ? "DA" : "NE");
                lvAutobusi.Items[i].SubItems.Add(ka.Autobusi[i].ImaToalet ? "DA" : "NE");
                
                lvAutobusi.Items[i].Tag = ka.Autobusi[i];
            }
        }

        public void promjenjenAutobus(DAL.Entiteti.Autobus a)
        {
            popuniAutobuse();
        }

        public void noviAutobus(DAL.Entiteti.Autobus a)
        {
            ka.Autobusi.Add(a);
            popuniAutobuse();
        }

        private void listView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = (sender as ListView).Columns[e.ColumnIndex].Width;
        }

        private void lvAutobusi_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count == 0) return;

            UredjivanjeAutobusa ua = new UredjivanjeAutobusa((lv.SelectedItems[0].Tag as DAL.Entiteti.Autobus),this);
            ua.Show();
        }

        private void tsbNoviAutobus_Click(object sender, EventArgs e)
        {
            DodajNoviAutobus dna = new DodajNoviAutobus(this);
            dna.Show();
        }

        private void tsbBrisi_Click(object sender, EventArgs e)
        {
            DAL.Entiteti.Autobus a;
            foreach (ListViewItem lvi in lvAutobusi.CheckedItems)
            {
                a = lvi.Tag as DAL.Entiteti.Autobus;
                if (!a.Slobodan)
                {
                    MessageBox.Show("Možete jedino brisati slobodne autobuse. Prvo uklonite sve vožnje za dati autobus!");
                    return;
                }
            }
            DialogResult dres = MessageBox.Show("Da li ste sigurni da zelite obrisati oznacene autobuse?", "Obrisati?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dres == DialogResult.Yes)
            {
                d.kreirajKonekciju();
                ad = d.getDAO.getAutobusDAO();
                try
                {
                    foreach (ListViewItem lvi in lvAutobusi.CheckedItems)
                    {
                        a = lvi.Tag as DAL.Entiteti.Autobus;

                        ad.delete(a);
                        ka.Autobusi.Remove(a);
                        lvAutobusi.Items.Remove(lvi);
                    }
                    MessageBox.Show("Autobusi su uspješno izbrisani iz sistema!");
                    popuniAutobuse();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
        }

    }
}
