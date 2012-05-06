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
    class VrijemeUpaljenost : VisestrukoDugme
    {
        public VrijemeUpaljenost()
            : base()
        {
            tekstura1 = "satDugmeOn";
            tekstura2 = tekstura3 = "satDugmeOff";
            Tooltip = "Prikazivanje vremena igranja";
        }

        public override void doButtonWork(GameTime gameTime)
        {
            if (InputHandler.ConfirmClicked)
            {
                if (stanje == 0)
                {
                    stanje = 1;
                    Opcije.vrijemeUkljuceno = false;
                }
                else
                {
                    stanje = 0;
                    Opcije.vrijemeUkljuceno = true;
                }
            }
        }


    }
}
