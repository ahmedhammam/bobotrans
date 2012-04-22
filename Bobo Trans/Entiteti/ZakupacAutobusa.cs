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
        private float cijena;
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

        public float Cijena
        {
            get { return cijena; }
            set { cijena = value; }
        }

        public Autobus Autobus
        {
            get { return autobus; }
            set { autobus = value; }
        }

        public ZakupacAutobusa(int sK, string i, DateTime pZ, DateTime kZ, float c, Autobus a)
            : base(sK, i)
        {
            pocetakZakupa = pZ;
            krajZakupa = kZ;
            cijena = c;
            autobus = a;
        }

        public ZakupacAutobusa(string i, DateTime pZ, DateTime kZ, float c, Autobus a)
            : base(i)
        {
            pocetakZakupa = pZ;
            krajZakupa = kZ;
            cijena = c;
            autobus = a;
        }
    }
}
