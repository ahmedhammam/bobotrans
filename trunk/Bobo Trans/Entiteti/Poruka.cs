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


        #region GetteriSetteri
        public long SifraPoruke
        {
            get { return sifraPoruke; }
            set { sifraPoruke = value; }
        }

        public string Primalac
        {
            get { return primalac; }
            set { primalac = value; }
        }

        public string Posiljaoc
        {
            get { return posiljaoc; }
            set { posiljaoc = value; }
        }

        public string Tekst
        {
            get { return tekst; }
            set { tekst = value; }
        }
        public DateTime VrijemeSlanja
        {
            get { return vrijemeSlanja; }
            set { vrijemeSlanja = value; }
        } 
        #endregion



        public Poruka(long sP, string t, string pos, string prim, DateTime vS)
        {
            sifraPoruke = sP;
            tekst = t;
            posiljaoc = pos;
            primalac = prim;
            vrijemeSlanja = vS;
        }

        public Poruka(string t, string pos, string prim, DateTime vS)
        {
            tekst = t;
            posiljaoc = pos;
            primalac = prim;
            vrijemeSlanja = vS;
        }

        public string ImeIDatumPrimljenih()
        {
            return posiljaoc+"          "+Convert.ToString(vrijemeSlanja);
        }


        public string ImeIDatumPoslanih()
        {
            return primalac + "        " + Convert.ToString(vrijemeSlanja);
        }

    }
}
