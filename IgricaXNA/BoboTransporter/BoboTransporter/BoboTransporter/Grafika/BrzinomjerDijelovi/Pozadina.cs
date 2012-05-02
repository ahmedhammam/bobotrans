using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika.BrzinomjerDijelovi
{
    class Pozadina:Slicica
    {
        static private string tekstura = "Speedo\\pozadinaTekstura";

        public Pozadina()
            : base()
        {
            Velicina = 1f;
            VertikalnaPozicija = 0.1f;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, tekstura);
        }
    }
}
