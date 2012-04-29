using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika.Podloge
{
    class LinijaStopNaCesti : Slicica
    {
        static private string tekstura = "linijaStopCestaTekstura";

        public LinijaStopNaCesti(int rotacija)
            : base()
        {
            Velicina = 0.25f;
            VertikalnaPozicija = 0.015f;
            Okvir = new Rectangle(0, 0, 600, 600);
            Sredina = new Vector2(300, 300);
            Rotacija = (float)(Math.PI * rotacija / 2);
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, tekstura);
        }
    }
}
