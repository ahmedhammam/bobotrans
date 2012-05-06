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
    class BrzinomjerUpaljenost:VisestrukoDugme
    {
        public BrzinomjerUpaljenost()
            : base()
        {
            tekstura1 = "brzinomjerDugmeOn";
            tekstura2 = tekstura3 = "brzinomjerDugmeOff";
            Tooltip = "Prikazivanje brzine";
        }

        public override void doButtonWork(GameTime gameTime)
        {
            if (InputHandler.ConfirmClicked)
            {
                if (stanje == 0)
                {
                    stanje = 1;
                    Opcije.brzinomjerUkljucen = false;
                }
                else
                {
                    stanje = 0;
                    Opcije.brzinomjerUkljucen = true;
                }
            }
        }


    }
}
