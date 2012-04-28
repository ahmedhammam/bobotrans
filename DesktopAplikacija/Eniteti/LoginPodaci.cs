using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopAplikacija
{
    public  class LoginPodaci
    {
       private  static string sifraKorisnika;
        private static string usernameKorisnika;
        public LoginPodaci(string sifra, string user)
        {
            sifraKorisnika = sifra;
            usernameKorisnika = user;
        }

        public string UsernameKorisnika
        {
             get{return usernameKorisnika;}
             set{usernameKorisnika=value;}
        }

        public string SifraKorisnika
        {
            get { return sifraKorisnika; }
            set { sifraKorisnika = value; }
        }
    }
}
