using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika
{
    class Drvo : Slicica
    {
        static private string tekstura = "drvoTekstura";

        public Drvo()
            : base()
        {
            Velicina = 0.26f;
            VertikalnaPozicija = 0.5f;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, tekstura);
        }
    }
}
