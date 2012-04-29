using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika.Podloge
{
    class Asfalt:Slicica
    {
        static private string tekstura = "asfaltTekstura";

        public Asfalt() : base()
        {
            Velicina = 0.26f;
            VertikalnaPozicija = 0.01f;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, tekstura);
        }
    }
}
