using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class Linija
    {
        private int sifraLinije;
        private string nazivLinije;

        private List<Stanica> stanice = new List<Stanica>();
        private List<int> trajanjeDoDolaska = new List<int>();
        private List<int> trajanjeDoPolaska = new List<int>();
        private List<List<int>> cijene;

        private List<Voznja> voznje = new List<Voznja>();

        public void dodajVoznju(int sifraVoznje, DateTime vrijemePolaska, Autobus autobus)
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
