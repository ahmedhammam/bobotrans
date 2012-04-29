using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika.Podloge
{
    class Cilj : Slicica
    {
        static private string tekstura = "ciljTekstura";

        public Cilj()
            : base()
        {
            Velicina = 0.5f;
            VertikalnaPozicija = 0.025f;
            Okvir = new Rectangle(0, 0, 300, 300);
            Sredina = new Vector2(150, 150);
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, tekstura);
        }
    }
}
