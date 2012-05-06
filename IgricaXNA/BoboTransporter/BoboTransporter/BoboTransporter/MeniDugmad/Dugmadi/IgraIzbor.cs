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
    class IgraIzbor : VisestrukoDugme
    {
        public IgraIzbor()
            : base()
        {
            tekstura1 = "nasumicnoDugme";
            tekstura2 = "travaDugme";
            tekstura3 = "snijegDugme";
            Tooltip = "Izbor godisnjeg doba";
        }

        public override void doButtonWork(GameTime gameTime)
        {
            if (InputHandler.ConfirmClicked)
            {
                if (stanje == 0)
                {
                    stanje = 1;
                }
                else if (stanje == 1)
                {
                    stanje = 2;
                }
                else
                {
                    stanje = 0;
                }
                Opcije.snijegNaMapi = stanje;
            }
        }


    }
}
