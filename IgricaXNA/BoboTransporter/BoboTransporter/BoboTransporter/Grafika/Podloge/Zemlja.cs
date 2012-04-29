using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika.Podloge
{
    class Zemlja : Slicica
    {
        static private string tekstura = "zemljaTekstura";

        public Zemlja()
            : base()
        {
            Velicina = 0.51f;
            VertikalnaPozicija = 0.005f;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, tekstura);
        }
    }
}
