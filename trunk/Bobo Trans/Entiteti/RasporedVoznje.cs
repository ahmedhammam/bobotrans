using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class RasporedVoznje
    {
        private long sifraRasporedaVoznji;
        private string danUSedmici;
        private DateTime vrijeme;
        private long potrebanBrojSjedista;


        #region GetteriSetteri
        public string DanUSedmici
        {
            get { return danUSedmici; }
            set { danUSedmici = value; }
        }
        public long SifraRasporedaVoznji
        {
            get { return sifraRasporedaVoznji; }
            set { sifraRasporedaVoznji = value; }
        }
        public DateTime Vrijeme
        {
            get { return vrijeme; }
            set { vrijeme = value; }
        }

        public long PotrebanBrojSjedista
        {
            get { return potrebanBrojSjedista; }
            set { potrebanBrojSjedista = value; }
        } 
        #endregion

        public RasporedVoznje(string dUS,DateTime v, long pBS)
        {
            DanUSedmici = dUS;
            vrijeme = v;
            potrebanBrojSjedista = pBS;
        }

        public RasporedVoznje(long sRV,string dUS, DateTime v, long pBS)
        {
            danUSedmici = dUS;
            sifraRasporedaVoznji = sRV;
            vrijeme = v;
            potrebanBrojSjedista = pBS;
        }

    }
}
