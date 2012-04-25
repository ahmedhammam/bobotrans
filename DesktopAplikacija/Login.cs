using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DAL;

namespace DesktopAplikacija
{
    public partial class Login : Form
    {
        public Login()
        {


            /*string username;
            string password;
            DAL.DAL d = DAL.DAL.Instanca;
            DAL.DAL.KorisnikDAO kd = d.getDAO.getKorisnikDAO();

            DAL.Entiteti.Korisnik k = kd.getByExample("username",username);
            if (k.Password == password)
            {
                LoginPodaci.usernameKorisnika = k.Username;
                LoginPodaci.sifraKorisnika = k.SifraKorisnika;
                if (k.Tip == DAL.TipoviPodataka.TipoviKorisnika.MENAGER)
                {
                }
            }*/

            InitializeComponent();
        }
    }
}
