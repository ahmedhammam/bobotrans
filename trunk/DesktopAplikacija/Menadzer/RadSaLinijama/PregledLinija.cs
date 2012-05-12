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

        private DAL.Entiteti.Linija dajSelektiranuLiniju()
        {
            if (lvLinije.SelectedItems.Count == 0)
                throw new Exception("Niste odabrali liniju!");

            return (lvLinije.SelectedItems[0].Tag as DAL.Entiteti.Linija);
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            DodajNovuLiniju dnl = new DodajNovuLiniju(this);
            dnl.Show();
        }

        public void promjenjenaLinija()
        {
            popuniListViewLinije();
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DAL.Entiteti.Linija odabranaLinija = dajSelektiranuLiniju();

                DialogResult dres = MessageBox.Show("Da li ste sigurni da želite obrisati selektiranu liniju?", "Brisati?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dres == DialogResult.Yes)
                {
                    kl.izbrisiLiniju(odabranaLinija);
                    lvLinije.Items.Remove(lvLinije.SelectedItems[0]);
                    MessageBox.Show("Linija je uspješno obrisana!");
                }

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUredi_Click(object sender, EventArgs e)
        {
            if (lvLinije.SelectedItems.Count == 0) return;
            UredjivanjeLinije ul = new UredjivanjeLinije(lvLinije.SelectedItems[0].Tag as DAL.Entiteti.Linija, this);
            ul.Show();
        }

    }
}
