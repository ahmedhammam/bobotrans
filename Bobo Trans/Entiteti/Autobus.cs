using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Autobus
    {
        private int sifraAutobusa, brojSjedista;
        private string registracijskeTablice;
        private bool imaToalet, slobodan, imaKlimu;
        private DateTime istekRegistracije, datumServisa;

        public Autobus(int idAutobusa, int brSjedista, string regTablice, bool toalet, bool slob, bool klima, DateTime istekReg, DateTime datServisa)
        {
            sifraAutobusa = idAutobusa;
            brojSjedista = brSjedista;
            registracijskeTablice = regTablice;
            imaToalet = toalet;
            slobodan = slob;
            imaKlimu = klima;
            istekRegistracije = istekReg;
            datumServisa = datServisa;
        }

        public DateTime DatumServisa
        {
            get { return datumServisa; }
            set { datumServisa = value; }
        }

        public DateTime IstekRegistracije
        {
            get { return istekRegistracije; }
            set { istekRegistracije = value; }
        }

        public int SifraAutobusa
        {
            get { return sifraAutobusa; }
            set { sifraAutobusa = value; }
        }

        public int BrojSjedista
        {
            get { return brojSjedista; }
            set { brojSjedista = value; }
        }
        public string RegistracijskeTablice
        {
            get { return registracijskeTablice; }
            set { registracijskeTablice = value; }
        }

        public bool ImaToalet
        {
            get { return imaToalet; }
            set { imaToalet = value; }
        }

        public bool Slobodan
        {
            get { return slobodan; }
            set { slobodan = value; }
        }

        public bool ImaKlimu
        {
            get { return imaKlimu; }
            set { imaKlimu = value; }
        }
    }
}
