using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika.Podloge
{
    class Snijeg : Slicica
    {
        static private string tekstura = "snijegTekstura";
        public Snijeg()
            : base()
        {
            Velicina = 0.5f;
            Okvir = new Rectangle(50, 50, 300, 300);
            Sredina = new Vector2(150, 150);
            VertikalnaPozicija = 0.005f;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, tekstura);
        }
    }
}
