using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Izvjestaj
    {
        private DateTime datumServisa;
        private string tekst;
        private long sifraIzvjestaja;
        private long sifraKreatora;

        public long SifraKreatora
        {
            get { return sifraKreatora; }
            set { sifraKreatora = value; }
        }

        public DateTime DatumServisa
        {
            get { return datumServisa; }
            set { datumServisa = value; }
        }
        
        public string Tekst
        {
            get { return tekst; }
            set { tekst = value; }
        }

        public long SifraIzvjestaja
        {
            get { return sifraIzvjestaja; }
            set { sifraIzvjestaja = value; }
        }

        public Izvjestaj(DateTime dat, string t)
        {
            datumServisa = dat;
            tekst = t;
        }

        public Izvjestaj(long sI,DateTime dat, string t)
        {
            sifraIzvjestaja = sI;
            datumServisa = dat;
            tekst = t;
        }



    }
}
