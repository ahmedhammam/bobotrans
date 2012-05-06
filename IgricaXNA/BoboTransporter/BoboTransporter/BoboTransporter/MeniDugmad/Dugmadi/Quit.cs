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
    class Quit:ObicnoDugme
    {
        public Quit()
            : base()
        {
            tekstura = "izadjiDugme";
            Tooltip = "Izlaz iz igre";
        }

        public override void doButtonWork(GameTime gameTime)
        {
            if (InputHandler.ConfirmClicked)
            {
                Opcije.gamePointer.stanje = StanjeIgre.IZADJI_MENI;
                Opcije.gamePointer.loadaj = true;
            }
        }


    }
}
