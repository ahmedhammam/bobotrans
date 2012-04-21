using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    class Izvjestaj
    {
        private DateTime datumServisa;
        private string tekst;

        public Izvjestaj(DateTime dat, string t)
        {
            datumServisa = dat;
            tekst = t;
        }
    }
}
