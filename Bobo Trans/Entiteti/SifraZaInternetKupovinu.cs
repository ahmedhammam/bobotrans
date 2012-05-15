using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class SifraZaInternetKupovinu
    {
            private long idSifre;
            private long sifraKorisnika;
            private string sifra;
            
            public long IdSifre
            {
                get { return idSifre; }
                set { idSifre = value; }
            }

            public long SifraKorisnika
            {
                get { return sifraKorisnika; }
                set { sifraKorisnika = value; }
            }

            public string Sifra
            {
                get { return sifra; }
                set { sifra = value; }
            }    

            public SifraZaInternetKupovinu(long iS,long sK, string sif)
            {
                idSifre = iS;
                sifraKorisnika = sK;
                sifra = sif;
            }

            public SifraZaInternetKupovinu(long sK, string sif)
            {
                sifraKorisnika = sK;
                sifra = sif;
            }
    }
}
