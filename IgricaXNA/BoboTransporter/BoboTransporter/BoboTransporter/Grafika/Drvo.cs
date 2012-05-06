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
        static int brojacDrveca = 0;
        public Drvo()
            : base()
        {
            Velicina = 0.26f;
            brojacDrveca++;
            VertikalnaPozicija = 0.5f+brojacDrveca/10000f;
        }

        public static void resetujBrojacDrveca()
        {
            brojacDrveca = 0;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, tekstura);
        }
    }
}
