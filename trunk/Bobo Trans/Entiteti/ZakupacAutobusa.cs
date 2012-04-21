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

        public ZakupacAutobusa(int sK, string i, DateTime pZ, DateTime kZ, float c, Autobus a):base(sK,i)
        {
            pocetakZakupa = pZ;
            krajZakupa = kZ;
            cijena = c;
            autobus = a;
        }
    }
}
