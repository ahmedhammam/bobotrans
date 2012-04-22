using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Poruka
    {

        private long sifraPoruke;
        private string tekst, posiljaoc, primalac;
        private DateTime vrijemeSlanja;

        public Poruka(string t, string pos, string prim, DateTime vS)
        {
            tekst = t;
            posiljaoc = pos;
            primalac = prim;
            vrijemeSlanja = vS;
        }
    }
}
