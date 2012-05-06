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
    class PokreniIgru:ObicnoDugme
    {
        public PokreniIgru()
            : base()
        {
            tekstura = "igrajDugme";
            Tooltip = "Pokreni igru";
        }

        public override void doButtonWork(GameTime gameTime)
        {
            if (InputHandler.ConfirmClicked)
            {
                Opcije.gamePointer.stanje = StanjeIgre.U_IGRI;
                Opcije.gamePointer.pokreniIgru(gameTime);
                //POCNI IGRU ! ! ! ! !
            }
        }


    }
}
