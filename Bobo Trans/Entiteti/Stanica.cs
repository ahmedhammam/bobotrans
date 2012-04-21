using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Stanica
    {
        private int sifraStanice;
        private string naziv;
        private string mjesto;

        public Stanica(int i, string n, string m)
        {
            sifraStanice = i;
            naziv = n;
            mjesto = m;
        }

        public int Id
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
    }
}
