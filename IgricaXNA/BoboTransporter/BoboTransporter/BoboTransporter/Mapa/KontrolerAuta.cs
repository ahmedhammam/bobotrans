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
            /*for (int i = 0; i < (mapa.Sirina - 8) * 4; i++)
                polje[i, 0] = polje[i, (mapa.Visina - 8) * 4 - 1] = 1;
            for (int i = 0; i < (mapa.Visina - 8) * 4; i++)
                polje[0,i] = polje[(mapa.Sirina - 8) * 4 - 1,i] = 1;*/
            
            /*for (int j = 0; j < (mapa.Visina - 8) * 4; j++)
            {
                if (j % 4 == 0) Console.WriteLine();

                for (int i = 0; i < (mapa.Sirina - 8) * 4; i++)
                {
                    if (i % 4 == 0) Console.Write(' ');
                    if (polje[i, j] == 0) Console.Write('-');
                    else if (polje[i, j] == 1) Console.Write('R');
                    else if (polje[i, j] == -1) Console.Write('L');
                }
                Console.WriteLine();
            }*/
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
