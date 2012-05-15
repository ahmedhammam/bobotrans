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

            return -1;
        }

    }
}
