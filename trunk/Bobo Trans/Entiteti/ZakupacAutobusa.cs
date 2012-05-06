using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class ZakupacAutobusa: Kupac
    {
        private DateTime pocetakZakupa;
        private DateTime krajZakupa;
        private double cijena;
        private Autobus autobus;

        public DateTime PocetakZakupa
        {
            get { return pocetakZakupa; }
            set { pocetakZakupa = value; }
        }
        
        public DateTime KrajZakupa
        {
            get { return krajZakupa; }
            set { krajZakupa = value; }
        }

        public double Cijena
        {
            get { return cijena; }
            set { cijena = value; }
        }

        public Autobus Autobus
        {
            get { return autobus; }
            set { autobus = value; }
        }

        public ZakupacAutobusa(long sK, string i, DateTime pZ, DateTime kZ, double c, Autobus a)
            : base(sK, i)
        {
            pocetakZakupa = pZ;
            krajZakupa = kZ;
            cijena = c;
            autobus = a;
        }

        public ZakupacAutobusa(string i, DateTime pZ, DateTime kZ, double c, Autobus a)
            : base(i)
        {
            pocetakZakupa = pZ;
            krajZakupa = kZ;
            cijena = c;
            autobus = a;
        }
    }
}
