using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.TipoviPodataka;

namespace DAL.Entiteti
{
    public class Korisnik
    {

            private long sifraKorisnika;
            private string username, imeIPrezime;
            private string password;
            private TipoviKorisnika tip;

            public Korisnik(long sK, string u, string iP, TipoviKorisnika t, string pass)
            {
                sifraKorisnika = sK;
                username = u;
                imeIPrezime = iP;
                tip = t;
                password = pass;
            }

            public Korisnik(string u, string iP, TipoviKorisnika t, string pass)
            {
                username = u;
                imeIPrezime = iP;
                tip = t;
                password = pass;
            }
    public     string ToString() 
        { return imeIPrezime;
    }



    

            #region GetteriSetteri
            public string ImeIPrezime
            {
                get { return imeIPrezime; }
                set { imeIPrezime = value; }
            }

            public TipoviKorisnika Tip
            {
                get { return tip; }
                set { tip = value; }
            }


            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            public long SifraKorisnika
            {
                get { return sifraKorisnika; }
                set { sifraKorisnika = value; }
            }
            public string Username
            {
                get { return username; }
                set { username = value; }
            } 
            #endregion
    }
}
