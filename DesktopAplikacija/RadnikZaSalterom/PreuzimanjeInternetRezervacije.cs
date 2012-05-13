using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DesktopAplikacija.RadnikZaSalterom
{
    public partial class PreuzimanjeInternetRezervacije : Form
    {
        public PreuzimanjeInternetRezervacije()
        {
            InitializeComponent();
        }

        private void btnIzadji_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            int id=-1;
            try
            {
                id = deshifruj(tbSifra.Text.ToUpper());
            }
            catch
            {
                //MessageBox.Show("Neispravna šifra", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (id < 0) MessageBox.Show("Neispravna šifra", "Greška",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private int deshifruj(string sifra)
        {
            if (sifra.Length != 14) throw new Exception("ne valja");
            int idKupca=0;
            for (int i = 0; i < 7; i++)
            {
                idKupca *= 32;
                idKupca += dajCifru(sifra[i * 2]);
            }
            MessageBox.Show(idKupca.ToString());
            return -1;
        }

        private int dajCifru(char x)
        {
            if (x >= '0' && x <= '9') return ((int)x - 48);
            else return ((int)x - 65);
        }
    }
}
