using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.MeniDugmad.Poruke
{
    class Pomoc : Poruka
    {
        public Pomoc()
            : base()
        {
            tekstura = "Pomoc";
            osnovno_stanje.Okvir = new Rectangle(0, 0, 800, 500);
            osnovno_stanje.Sredina = new Vector2(400, 500);
        }
    }
}
