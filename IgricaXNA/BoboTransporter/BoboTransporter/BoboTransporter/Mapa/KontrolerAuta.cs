using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Mapa
{
    class KontrolerAuta
    {
        int[,] polje;

        public int[,] Polje
        {
            get { return polje; }
            set { polje = value; }
        }

        public KontrolerAuta(Mapa mapa)
        {
            polje = new int[(mapa.Sirina - 8)*4, (mapa.Visina - 8)*4];
            for (int i=0;i<(mapa.Sirina - 8)*4;i++)
                for (int j=0;j<(mapa.Visina - 8)*4;j++)
                    polje[i,j]=0;
            for (int i=4;i<mapa.Sirina-4;i++)
                for (int j = 4; j < mapa.Visina - 4; j++)
                {
                    postaviPolja(mapa.Blok[i,j],(i-4)*4,(j-4)*4);
                }
        }

        private void postaviPolja(Regija regija, int pX, int pY)
        {
            if (Regija.jeCesta(regija.Tip))
            {
                bool prU = Regija.jeProhodnaCesta(regija.TipGore);
                bool prD = Regija.jeProhodnaCesta(regija.TipDole);
                bool prL = Regija.jeProhodnaCesta(regija.TipLijevo);
                bool prR = Regija.jeProhodnaCesta(regija.TipDesno);
                if (prU && prL) polje[pX,pY]=1;
                if (prU && prR) polje[pX+3,pY]=1;
                if (prD && prL) polje[pX,pY+3]=1;
                if (prD && prR) polje[pX+3,pY+3]=1;
                if (!prU && !prL) polje[pX,pY]=-1;
                if (!prU && !prR) polje[pX+3,pY]=-1;
                if (!prD && !prL) polje[pX,pY+3]=-1;
                if (!prD && !prR) polje[pX+3,pY+3]=-1;
            }
        }
    }
}
