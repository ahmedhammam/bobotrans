using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Stanica
    {
        private long sifraStanice;
        private string naziv;
        private string mjesto;

        public Stanica(long sS, string n, string m)
        {
            sifraStanice = sS;
            naziv = n;
            mjesto = m;
        }

        public Stanica(string n, string m)
        {
            naziv = n;
            mjesto = m;
        }

        public long SifraStanice
        {
            get { return sifraStanice; }
            set { sifraStanice = value; }
        }

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }

        public string Mjesto
        {
            get { return mjesto; }
            set { mjesto = value; }
        }
        public override string ToString()
        {
            string naziv = String.Format("{0}, {1}",Naziv,Mjesto);
            return naziv;
        }
    }
}
