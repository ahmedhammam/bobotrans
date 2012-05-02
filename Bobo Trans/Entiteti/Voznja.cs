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

        public long SifraVoznje
        {
            get { return sifraVoznje; }
            set { sifraVoznje = value; }
        }

        public DateTime VrijemePolaska
        {
            get { return vrijemePolaska; }
            set { vrijemePolaska = value; }
        }

        public Autobus Autobus
        {
            get { return autobus; }
            set { autobus = value; }
        }

        public Voznja(long sifra, DateTime vrijeme, Autobus a)
        {
            sifraVoznje = sifra;
            vrijemePolaska = vrijeme;
            autobus = a;
        }

        public Voznja(DateTime vrijeme, Autobus a)
        {
            vrijemePolaska = vrijeme;
            autobus = a;
        }
        public override string ToString()
        {
            
            return sifraVoznje+ "                                      "+vrijemePolaska+"                     "+autobus.SifraAutobusa;
        }
    }
}
