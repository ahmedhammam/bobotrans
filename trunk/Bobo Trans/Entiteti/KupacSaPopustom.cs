using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.TipoviPodataka;

namespace DAL.Entiteti
{
    public class KupacSaPopustom:KupacKarte
    {
        protected double popust;
        private string podaci;
        private TipoviKupaca tipKupca;

        private new double proracunajCijenu()
        {
            return base.proracunajCijenu() * (1 - popust);
        }

        public KupacSaPopustom(int sK, string i, Stanica pS, Stanica kS, Voznja v, List<int> s,double p,string pod,TipoviKupaca tK)
            : base(sK, i, pS, kS, v, s)
        {
            popust = p;
            podaci = pod;
            tipKupca = tK;
        }
    }
}
