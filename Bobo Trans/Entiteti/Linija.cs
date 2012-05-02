using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Linija
    {
        private long sifraLinije;
        private string nazivLinije;

        private List<Stanica> stanice;
        private List<int> trajanjeDoDolaska;
        private List<int> trajanjeDoPolaska;

        private List<List<double>> cijene;
        private List<Voznja> voznje;
        private List<RasporedVoznje> rasporediVoznje;

        #region GetteriSetteri
        public long SifraLinije
        {
            get { return sifraLinije; }
            set { sifraLinije = value; }
        }

        public string NazivLinije
        {
            get { return nazivLinije; }
            set { nazivLinije = value; }
        }

        public List<Stanica> Stanice
        {
            get { return stanice; }
            set { stanice = value; }
        }

        public List<int> TrajanjeDoDolaska
        {
            get { return trajanjeDoDolaska; }
            set { trajanjeDoDolaska = value; }
        }

        public List<int> TrajanjeDoPolaska
        {
            get { return trajanjeDoPolaska; }
            set { trajanjeDoPolaska = value; }
        }

        public List<List<double>> Cijene
        {
            get { return cijene; }
            set { cijene = value; }
        }

        public List<Voznja> Voznje
        {
            get { return voznje; }
            set { voznje = value; }
        }

        public List<RasporedVoznje> RasporediVoznje
        {
            get { return rasporediVoznje; }
            set { rasporediVoznje = value; }
        }
        #endregion



        #region konstruktori
        public Linija(long sifra, string naziv, List<Stanica> stan, List<int> tDoDolaska, List<int> tDoPolaska, List<List<double>> c, List<Voznja> v, List<RasporedVoznje> rV)
        {
            sifraLinije = sifra;
            nazivLinije = naziv;
            stanice = stan;
            trajanjeDoDolaska = tDoDolaska;
            trajanjeDoPolaska = tDoPolaska;
            cijene = c;
            voznje = v;
            rasporediVoznje = rV;
        }

        public Linija(string naziv, List<Stanica> stan, List<int> tDoDolaska, List<int> tDoPolaska, List<List<double>> c, List<Voznja> v, List<RasporedVoznje> rV)
        {
            nazivLinije = naziv;
            stanice = stan;
            trajanjeDoDolaska = tDoDolaska;
            trajanjeDoPolaska = tDoPolaska;
            cijene = c;
            voznje = v;
            rasporediVoznje = rV;
        }
        
        #endregion


        public double vratiCijenu(Stanica s1, Stanica s2)
        {
            int i1 = 0, i2 = 0;
            while (stanice[i1].SifraStanice != s1.SifraStanice && i1 < stanice.Count) i1++;
            while (stanice[i2].SifraStanice != s2.SifraStanice && i2 < stanice.Count) i2++;

            if (i1 == stanice.Count || i2 == stanice.Count)
                throw new Exception("Jedna od stanica ne postoji u liniji");
            if (i1 > i2)
                throw new Exception("Linija ide u suprotnom smijeru od zadanih stanica");

            return cijene[i1][i2];

        }

        public void dodajVoznju(long sifraVoznje, DateTime vrijemePolaska, Autobus autobus)
        {
            voznje.Add(new Voznja(sifraVoznje, vrijemePolaska, autobus));
        }

        public void brisiVoznju(int sifraVoznje)
        {
            for (int i = 0; i < voznje.Count; i++)
            {
                if (voznje[i].SifraVoznje == sifraVoznje)
                {
                    voznje.RemoveAt(i);
                    break;
                }
            }
        }

        public int sadrziStanicu(Stanica stanica)
        {
            for (int i = 0; i < stanice.Count; i++)
                if (stanice[i].SifraStanice == stanica.SifraStanice)
                    return i;

            return -1;
        }
        public override string ToString()
        {
            string naziv = NazivLinije;
            return " "+naziv;
        }
    }
}
