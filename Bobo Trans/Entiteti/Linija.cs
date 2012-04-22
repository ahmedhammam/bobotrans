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

        public List<List<int>> Cijene
        {
            get { return cijene; }
            set { cijene = value; }
        }

        private List<Voznja> voznje;

        public List<Voznja> Voznje
        {
            get { return voznje; }
            set { voznje = value; }
        }



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
