using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class RasporedVoznjeAutobus
    {
        private long sifraRasporedaVoznjeAutobus;
        private long autobus;
        private long rasporedVoznje;

        public long SifraRasporedaVoznjeAutobus
        {
            get { return sifraRasporedaVoznjeAutobus; }
            set { sifraRasporedaVoznjeAutobus = value; }
        }

        public long Autobus
        {
            get { return autobus; }
            set { autobus = value; }
        }

        public long RasporedVoznje
        {
            get { return rasporedVoznje; }
            set { rasporedVoznje = value; }
        }


        public RasporedVoznjeAutobus(long sRVA,long a,long rv)
        {
            sifraRasporedaVoznjeAutobus = sRVA;
            autobus = a;
            rasporedVoznje =rv;
        }

        public RasporedVoznjeAutobus(long a,long rv)
        {
            autobus = a;
            rasporedVoznje =rv;
        }

    }
}
