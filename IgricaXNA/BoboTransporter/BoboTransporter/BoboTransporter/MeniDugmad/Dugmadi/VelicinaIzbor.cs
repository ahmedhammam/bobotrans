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
    class VelicinaIzbor : VisestrukoDugme
    {
        public VelicinaIzbor()
            : base()
        {
            tekstura1 = "velicinaDugmeMala";
            tekstura2 = "velicinaDugmeSrednja";
            tekstura3 = "velicinaDugmeVelika";
            Tooltip = "Izbor velicine labirinta";
        }

        public override void doButtonWork(GameTime gameTime)
        {
            if (InputHandler.ConfirmClicked)
            {
                if (stanje == 0)
                {
                    stanje = 1;
                    Opcije.dimenzijaMape = 12;
                }
                else if (stanje == 1)
                {
                    stanje = 2;
                    Opcije.dimenzijaMape = 20;
                }
                else
                {
                    stanje = 0;
                    Opcije.dimenzijaMape = 5;
                }
            }
        }


    }
}
