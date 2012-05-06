using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika
{
    class Kamen : Slicica
    {
        static private string tekstura = "Kamen\\kamen{0}Tekstura";
        int brojTeksture;
        static int brojacKamenja = 0;
        public Kamen(int brTek)
            : base()
        {
            Velicina = 0.06f;
            brojacKamenja++;
            VertikalnaPozicija = 0.21f+brojacKamenja/100000f;
            brojTeksture = brTek;
        }

        public static void resetujBrojacKamenja()
        {
            brojacKamenja = 0;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, String.Format(tekstura, brojTeksture));
        }
    }
}
