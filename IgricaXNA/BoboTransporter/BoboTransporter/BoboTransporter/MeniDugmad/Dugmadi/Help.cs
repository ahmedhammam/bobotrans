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
    class Help:ObicnoDugme
    {
        public Help()
            : base()
        {
            tekstura = "pomocDugme";
            Tooltip = "Pomoc u igranju igre";
        }

        public override void doButtonWork(GameTime gameTime)
        {
            if (InputHandler.ConfirmClicked)
            {
                Opcije.gamePointer.stanje = StanjeIgre.POMOC;
                Opcije.gamePointer.loadaj = true;
            }
        }


    }
}
