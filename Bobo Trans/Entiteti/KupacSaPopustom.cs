using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DAL.TipoviPodataka;

namespace DAL.Entiteti
{
    public class KupacSaPopustom:KupacKarte
    {
        private double popust;
        private string podaci;
        private TipoviKupaca tipKupca;

        public double Popust
        {
            get { return popust; }
            set { popust = value; }
        }
        

        public string Podaci
        {
            get { return podaci; }
            set { podaci = value; }
        }
       

        public TipoviKupaca TipKupca
        {
            get { return tipKupca; }
            set { tipKupca = value; }
        }

        public new double proracunajCijenu()
        {
            return base.proracunajCijenu() * (1 - popust);
        }

        public KupacSaPopustom(int sK, string i, Stanica pS, Stanica kS, Voznja v, List<int> s, List<double> c, double p, string pod, TipoviKupaca tK)
            : base(sK, i, pS, kS, v, s, c)
        {
            popust = p;
            podaci = pod;
            tipKupca = tK;
        }

        public KupacSaPopustom(string i, Stanica pS, Stanica kS, Voznja v, List<int> s, List<double> c, double p, string pod, TipoviKupaca tK)
            : base(i, pS, kS, v, s, c)
        {
            popust = p;
            podaci = pod;
            tipKupca = tK;
        }
    }
}
