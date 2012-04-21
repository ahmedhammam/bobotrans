using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Voznja
    {
        private int sifraVoznje;
        private DateTime vrijemePolaska;
        private Autobus autobus;

        public Voznja(int sifra, DateTime vrijeme, Autobus a)
        {
            sifraVoznje = sifra;
            vrijemePolaska = vrijeme;
            autobus = a;
        }
        public int SifraVoznje
        {
            get { return sifraVoznje; } 
        }
    }
}
