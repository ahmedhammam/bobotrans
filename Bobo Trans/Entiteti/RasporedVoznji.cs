using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class RasporedVoznji
    {
        private long sifraRasporedaVoznji;
        private DateTime vrijeme;
        private long potrebanBrojSjedista;

        public RasporedVoznji(DateTime v, long pBS)
        {
            vrijeme = v;
            potrebanBrojSjedista = pBS;
        }

        public RasporedVoznji(long sRV, DateTime v, long pBS)
        {
            sifraRasporedaVoznji = sRV;
            vrijeme = v;
            potrebanBrojSjedista = pBS;
        }

    }
}
