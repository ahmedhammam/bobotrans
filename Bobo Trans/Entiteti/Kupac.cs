using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public abstract class Kupac
    {
        protected int sifraKupca;
        protected string ime;

        public Kupac(int sK, string i)
        {
            sifraKupca = sK;
            ime = i;
        }
    }
}
