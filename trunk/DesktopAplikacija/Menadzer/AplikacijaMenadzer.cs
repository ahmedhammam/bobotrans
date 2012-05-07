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
    public partial class AplikacijaMenadzer : Form
    {
        private DAL.Entiteti.Korisnik logovaniKorisnik;
        public AplikacijaMenadzer(DAL.Entiteti.Korisnik k)
        {
            logovaniKorisnik = k;
            InitializeComponent();
        }

        private void informisanjeOLinijamaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Informisanje.InformisanjeLinije il = new Informisanje.InformisanjeLinije();
                il.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void izvodIzRedaVožnjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Informisanje.IzvodIzRedaVoznje irv = new Informisanje.IzvodIzRedaVoznje();
                irv.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void nalaženjeNajjeftinijegPutaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Informisanje.NajjeftinijiPut np = new Informisanje.NajjeftinijiPut();
                np.Show();
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }

        private void btnAutobus_Click(object sender, EventArgs e)
        {
            PregledAutobusa pa = new PregledAutobusa();
            pa.Show();
        }

        private void tsbPoruke_Click(object sender, EventArgs e)
        {
            Poruke.aplikacijaPoruke ap = new Poruke.aplikacijaPoruke(logovaniKorisnik);
            ap.Show();
        }

        private void btnIznajmljivanje_Click(object sender, EventArgs e)
        {
            IznajmljivanjeAutobusa ia = new IznajmljivanjeAutobusa();
            ia.Show();
        }

        private void btnLinije_Click(object sender, EventArgs e)
        {
            PregledLinija pl = new PregledLinija();
            pl.Show();
        }
    }
}
