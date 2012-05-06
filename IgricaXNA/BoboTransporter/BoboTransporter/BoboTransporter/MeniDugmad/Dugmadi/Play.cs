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
    class Play:ObicnoDugme
    {
        public Play()
            : base()
        {
            tekstura = "igrajDugme";
            Tooltip = "Pocni novu igru";
        }

        public override void doButtonWork(GameTime gameTime)
        {
            if (InputHandler.ConfirmClicked)
            {
                Opcije.gamePointer.stanje = StanjeIgre.POCNI_IGRU_MENI;
                Opcije.gamePointer.loadaj = true;
            }
        }


    }
}
