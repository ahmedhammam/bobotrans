using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Entiteti
{
    public class TipPopusta
    {
        int indeks_;

        public int Indeks
        {
          get { return indeks_; }
          set { indeks_ = value; }
        }

        private string tipPopusta;

        public string TipPopusta1
        {
          get { return tipPopusta; }
          set { tipPopusta = value; }
        }
        
        private double vrijednostPopusta;

        public double VrijednostPopusta
        {
          get { return vrijednostPopusta; }
          set { vrijednostPopusta = value; }
        }

        public TipPopusta(int indeks, string tip_popusta, double vrijednost_popusta)
        {
            indeks_ = indeks;
            tipPopusta = tip_popusta;
            vrijednostPopusta = vrijednost_popusta;
        }
    }
}
