using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika.BrzinomjerDijelovi
{
    class Strelica : Slicica
    {
        static private string tekstura = "Speedo\\strelicaTekstura";

        public Strelica()
            : base()
        {
            Velicina = 1f;
            VertikalnaPozicija = 0.2f;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, tekstura);
        }
    }
}
