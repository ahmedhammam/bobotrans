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
    class QuitNo:ObicnoDugme
    {
        public QuitNo()
            : base()
        {
            tekstura = "neDugme";
            Tooltip = "Vracanje u glavni meni";
        }

        public override void doButtonWork(GameTime gameTime)
        {
            if (InputHandler.ConfirmClicked)
            {
                Opcije.gamePointer.stanje = StanjeIgre.GLAVNI_MENI;
                Opcije.gamePointer.loadaj = true;
            }
        }


    }
}
