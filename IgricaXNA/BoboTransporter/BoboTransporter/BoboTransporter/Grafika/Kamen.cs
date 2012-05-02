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
        public Kamen(int brTek)
            : base()
        {
            Velicina = 0.06f;
            VertikalnaPozicija = 0.21f;
            brojTeksture = brTek;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, String.Format(tekstura, brojTeksture));
        }
    }
}
