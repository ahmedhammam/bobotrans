using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopAplikacija
{
    public static class LoginPodaci
    {
        public static long sifraKorisnika;
        public static string usernameKorisnika;
        public LoginPodaci(long sifra, string user)
        {
            sifraKorisnika = sifra;
            usernameKorisnika = user;
        }
    }
}
