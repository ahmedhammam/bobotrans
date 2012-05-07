using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DesktopAplikacija.Entiteti;

namespace DesktopAplikacija.Menadzer
{
    public partial class PregledLinija : Form
    {

        KolekcijaLinija kl = KolekcijaLinija.Instanca;

        public PregledLinija()
        {
            InitializeComponent();

            popuniListViewLinije();
        }

        private void popuniListViewLinije()
        {
            lvLinije.Items.Clear();

            for (int i = 0; i < kl.Linije.Count; i++)
            {
                lvLinije.Items.Add(kl.Linije[i].SifraLinije.ToString());
                lvLinije.Items[i].SubItems.Add(kl.Linije[i].NazivLinije);
                lvLinije.Items[i].Tag = kl.Linije[i];
            }
        }

        private void listView_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = (sender as ListView).Columns[e.ColumnIndex].Width;
        }

        private void lvLinije_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count == 0) return;
            UredjivanjeLinije ul = new UredjivanjeLinije(lv.SelectedItems[0].Tag as DAL.Entiteti.Linija, this);
            ul.Show();
        }
    }
}
