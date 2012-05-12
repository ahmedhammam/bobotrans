using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DAL.Entiteti;

namespace DesktopAplikacija.Menadzer
{
    public partial class PregledStanica : Form
    {
        private Entiteti.KolekcijaStanica ks = Entiteti.KolekcijaStanica.Instanca;
        private DAL.DAL d = DAL.DAL.Instanca;
        private DAL.DAL.StanicaDAO sd;
        private Entiteti.KolekcijaLinija kl = Entiteti.KolekcijaLinija.Instanca;

        public PregledStanica()
        {
            sd = d.getDAO.getStaniceDAO();
            InitializeComponent();
            popuniStanice();
        }

        public void promjenjenaStanica()
        {
            popuniStanice();
        }

        public void dodanaStanica(DAL.Entiteti.Stanica s)
        {
            ks.Stanice.Add(s);
            popuniStanice();
        }

        private void listView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = (sender as ListView).Columns[e.ColumnIndex].Width;
        }

        private void popuniStanice()
        {
            lvStanice.Items.Clear();
            for (int i = 0; i < ks.Stanice.Count; i++)
            {
                lvStanice.Items.Add(ks.Stanice[i].SifraStanice.ToString());
                lvStanice.Items[i].SubItems.Add(ks.Stanice[i].Naziv);
                lvStanice.Items[i].SubItems.Add(ks.Stanice[i].Mjesto);
                lvStanice.Items[i].Tag = ks.Stanice[i];
            }
        }

        private void btnIzaji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBrisi_Click(object sender, EventArgs e)
        {
            if (lvStanice.CheckedItems.Count == 0)
            {
                MessageBox.Show("Morate čekirati stanice koje želite izbrisati!");
                return;
            }
            Stanica s;
            foreach (ListViewItem lvi in lvStanice.CheckedItems)
            {
                if(kl.linijeSadrzeStanicu(lvi.Tag as Stanica))
                {
                            MessageBox.Show("Ne možete obrisati stanicu "+(lvi.Tag as Stanica).Naziv +" koja je dio linije, uklonite prvo stanicu iz svake od linija pa onda je izbrišite!");
                            return;
                }

            }

            DialogResult dres = MessageBox.Show("Da li ste sigurni da zelite obrisati oznacene stanice?", "Obrisati?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dres == DialogResult.Yes)
            {
                try
                {
                    foreach (ListViewItem lvi in lvStanice.CheckedItems)
                    {
                        s = lvi.Tag as Stanica;
                        ks.brisiStanicu(s);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }

                MessageBox.Show("Stanice su uspješno izbrisane iz sistema!");
                popuniStanice();
            }
            

        }

        private void tsbNovaStanica_Click(object sender, EventArgs e)
        {
            UredjivanjeStanice us = new UredjivanjeStanice(this);
            us.Show();
        }

        private void lvStanice_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count == 0) return;

            UredjivanjeStanice us = new UredjivanjeStanice(this, false, lv.SelectedItems[0].Tag as DAL.Entiteti.Stanica);
            us.Show();
        }

        
    }
}
