using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika.Podloge
{
    class Trotoar : Slicica
    {
        static private string tekstura = "trotoarTekstura";

        public Trotoar()
            : base()
        {
            Velicina = 0.13f;
            VertikalnaPozicija = 0.02f;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, tekstura);
        }
    }
}
