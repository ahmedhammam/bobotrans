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
            stampanjeRadi();
        }

        private void stampanjeRadi()
        {
            long id = -1;
            try
            {
                id = deshifruj(tbSifra.Text.ToUpper());
                try
                {
                    DAL.Entiteti.KupacKarte kupac = DAL.DAL.Instanca.getDAO.getKupacKarteDAO().getById(id);
                }
                catch (Exception ex)
                {
                    //znaci kupac karte sa popustom je
                    DAL.Entiteti.KupacSaPopustom kupac = DAL.DAL.Instanca.getDAO.getKupacKarteSPopustomDAO().getById(id);

                }
            }
            catch
            {
                //MessageBox.Show("Neispravna šifra", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (id < 0) MessageBox.Show("Neispravna šifra", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private long deshifruj(string sifra)
        {

            List<DAL.Entiteti.SifraZaInternetKupovinu> sif = DAL.DAL.Instanca.getDAO.getSifraZaInternetKupovinuDAO().getByExample("sifra", sifra);
            if (sif.Count != 1) throw new Exception("Neispravna šifra");
            return sif[0].SifraKorisnika;
        }

    }
}
