using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public abstract class Kupac
    {
        protected long sifraKupca;
        protected string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public long SifraKupca
        {
            get { return sifraKupca; }
            set { sifraKupca = value; }
        }

        public Kupac(long sK, string i)
        {
            sifraKupca = sK;
            ime = i;
        }
        public Kupac(string i)
        {
            ime = i;
        }
    }
}
