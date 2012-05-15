using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DesktopAplikacija.Entiteti;

namespace DesktopAplikacija.RadnikZaSalterom
{
    public partial class PreuzimanjeInternetRezervacije : Form
    {
        DAL.Entiteti.Korisnik prodavac;
        public PreuzimanjeInternetRezervacije(DAL.Entiteti.Korisnik prodavac_)
        {
            InitializeComponent();
            prodavac = prodavac_;
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

                    //uzimanje spiska stanica
                    long idLinije = DAL.DAL.Instanca.getDAO.getVoznjaDAO().dajIdLinije(kupac.Voznja.SifraVoznje);
                    List<DAL.Entiteti.Stanica> stanice = DAL.DAL.Instanca.getDAO.getLinijaDAO().getById(idLinije).Stanice;
                    StampacKarti stampac = new StampacKarti(kupac, stanice, prodavac);
                    stampac.Stampaj();
                    //Ent
                    
                }
                catch (Exception ex)
                {
                    //znaci kupac karte sa popustom je
                    DAL.Entiteti.KupacSaPopustom kupac = DAL.DAL.Instanca.getDAO.getKupacKarteSPopustomDAO().getById(id);

                    //uzimanje spiska stanica
                    long idLinije = DAL.DAL.Instanca.getDAO.getVoznjaDAO().dajIdLinije(kupac.Voznja.SifraVoznje);
                    List<DAL.Entiteti.Stanica> stanice = DAL.DAL.Instanca.getDAO.getLinijaDAO().getById(idLinije).Stanice;
                    StampacKarti stampac = new StampacKarti(kupac, stanice, prodavac);
                    stampac.Stampaj();
                }
            }
            catch
            {
                //MessageBox.Show("Neispravna šifra", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                id = -1;
            }
            if (id < 0) MessageBox.Show("Neispravna šifra", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private long deshifruj(string sifra)
        {

            List<DAL.Entiteti.SifraZaInternetKupovinu> sif = DAL.DAL.Instanca.getDAO.getSifraZaInternetKupovinuDAO().getByExample("sifra", sifra);
            if (sif.Count != 1) throw new Exception("Neispravna šifra");
            DAL.DAL.Instanca.getDAO.getSifraZaInternetKupovinuDAO().delete(sif[0]);
            return sif[0].SifraKorisnika;
        }

    }
}
