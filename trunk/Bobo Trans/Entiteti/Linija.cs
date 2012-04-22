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

        private List<List<int>> cijene;
        private List<Voznja> voznje;


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

        public List<List<int>> Cijene
        {
            get { return cijene; }
            set { cijene = value; }
        }

        public List<Voznja> Voznje
        {
            get { return voznje; }
            set { voznje = value; }
        } 
        #endregion



        public Linija(long sifra, string naziv, List<Stanica> stan, List<int> tDoDolaska, List<int> tDoPolaska, List<List<int>> c, List<Voznja> v)
        {
            sifraLinije = sifra;
            nazivLinije = naziv;
            stanice = stan;
            trajanjeDoDolaska = tDoDolaska;
            trajanjeDoPolaska = tDoPolaska;
            cijene = c;
            voznje = v;
        }

        public Linija(string naziv, List<Stanica> stan, List<int> tDoDolaska, List<int> tDoPolaska, List<List<int>> c, List<Voznja> v)
        {
            nazivLinije = naziv;
            stanice = stan;
            trajanjeDoDolaska = tDoDolaska;
            trajanjeDoPolaska = tDoPolaska;
            cijene = c;
            voznje = v;
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



    }
}
