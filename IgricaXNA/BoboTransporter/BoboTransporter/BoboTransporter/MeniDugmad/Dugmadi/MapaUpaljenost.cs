using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using BoboTransporter.EngineTools;

namespace BoboTransporter.MeniDugmad.Dugmadi
{
    class MapaUpaljenost:VisestrukoDugme
    {
        public MapaUpaljenost()
            : base()
        {
            tekstura1 = "mapaDugmeOn";
            tekstura2 = tekstura3 = "mapaDugmeOff";
            Tooltip = "Prikazivanje mape";
        }

        public override void doButtonWork(GameTime gameTime)
        {
            if (InputHandler.ConfirmClicked)
            {
                if (stanje == 0)
                {
                    stanje = 1;
                    Opcije.mapaUkljucena = false;
                }
                else
                {
                    stanje = 0;
                    Opcije.mapaUkljucena = true;
                }
            }
        }


    }
}
