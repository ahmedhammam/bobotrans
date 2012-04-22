using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Voznja
    {
        private long sifraVoznje;
        private DateTime vrijemePolaska;
        private Autobus autobus;

        public Voznja(long sifra, DateTime vrijeme, Autobus a)
        {
            sifraVoznje = sifra;
            vrijemePolaska = vrijeme;
            autobus = a;
        }
        public long SifraVoznje
        {
            get { return sifraVoznje; } 
        }
    }
}
