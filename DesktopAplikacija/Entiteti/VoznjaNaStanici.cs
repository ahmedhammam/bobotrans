using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesktopAplikacija.Entiteti
{
    public class VoznjaNaStanici
    {
        private string nazivLinije;
        private int sati, minute;

        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }

        public int Sati
        {
            get { return sati; }
            set { sati = value; }
        }

        public VoznjaNaStanici(string naziv, int h,int m)
        {
            nazivLinije = naziv;
            sati = h;
            minute = m;
        }




        public string NazivLinije
        {
            get { return nazivLinije; }
            set { nazivLinije = value; }
        }
    }
}
