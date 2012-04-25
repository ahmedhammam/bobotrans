using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopAplikacija
{
    public  class LoginPodaci
    {
        public static string sifraKorisnika;
        public static string usernameKorisnika;
        public LoginPodaci(string sifra, string user)
        {
            sifraKorisnika = sifra;
            usernameKorisnika = user;
        }
    }
}
