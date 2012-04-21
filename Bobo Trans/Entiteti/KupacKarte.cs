using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    class KupacKarte : Kupac
    {
        protected List<int> sjedista;
        protected Stanica pocetnaStanica;
        protected Stanica krajnjaStanica;
        protected Voznja voznja;

        public KupacKarte(int sK, string i, Stanica pS, Stanica kS, Voznja v, List<int> s)
            : base(sK, i)
        {
            pocetnaStanica = pS;
            krajnjaStanica = kS;
            voznja = v;
            sjedista = s;
        }

        public void proracunajCijenu()
        {
        }
    }
}
