using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopAplikacija.Entiteti
{
    public class Put
    {
        private double cijena;
        private string opisPuta;

        public string OpisPuta
        {
            get { return opisPuta; }
            set { opisPuta = value; }
        }

        public double Cijena
        {
            get { return cijena; }
            set { cijena = value; }
        }

        public Put(double c, string oP)
        {
            cijena = c;
            opisPuta = oP;
        }

        public override string ToString()
        {
            return (String.Format("{0}\nCijena: {1}", opisPuta, cijena.ToString()));
        }
    }
}
