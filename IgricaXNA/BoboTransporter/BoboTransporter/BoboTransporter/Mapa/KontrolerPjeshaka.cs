using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Mapa
{
    class KontrolerPjeshaka
    {
        int[,] polje;

        public int[,] Polje
        {
            get { return polje; }
            set { polje = value; }
        }

        public KontrolerPjeshaka(Mapa mapa)
        {
            polje = new int[(mapa.Sirina - 6) * 8, (mapa.Visina - 6) * 8];
            for (int i = 0; i < (mapa.Sirina - 6) * 4; i++)
                for (int j = 0; j < (mapa.Visina - 6) * 4; j++)
                    polje[i, j] = 0;
            for (int i = 3; i < mapa.Sirina - 3; i++)
                for (int j = 3; j < mapa.Visina - 3; j++)
                {
                    postaviPolja(mapa.Blok[i, j], (i - 3) * 8, (j - 3) * 8);
                }
        }

        private void postaviPolja(Regija regija, int pX, int pY)
        {
            if (!Regija.jeCestaIliCilj(regija.Tip))
            {
                bool trotCosakUL = false;
                bool trotCosakUR = false;
                bool trotCosakDL = false;
                bool trotCosakDR = false;
                bool trotStranaU = false;
                bool trotStranaD = false;
                bool trotStranaL = false;
                bool trotStranaR = false;
                if (Regija.jeCestaIliCilj(regija.TipDesno) || Regija.jeCestaIliCilj(regija.TipGore) || Regija.jeCestaIliCilj(regija.TipGoreDesno))
                {
                    trotCosakUR = true;
                }
                if (Regija.jeCestaIliCilj(regija.TipLijevo) || Regija.jeCestaIliCilj(regija.TipGore) || Regija.jeCestaIliCilj(regija.TipGoreLijevo))
                {
                    trotCosakUL = true;
                }
                if (Regija.jeCestaIliCilj(regija.TipDesno) || Regija.jeCestaIliCilj(regija.TipDole) || Regija.jeCestaIliCilj(regija.TipDoleDesno))
                {
                    trotCosakDR = true;
                }
                if (Regija.jeCestaIliCilj(regija.TipLijevo) || Regija.jeCestaIliCilj(regija.TipDole) || Regija.jeCestaIliCilj(regija.TipDoleLijevo))
                {
                    trotCosakDL = true;
                }
                if (Regija.jeCestaIliCilj(regija.TipGore))
                {
                    trotStranaU = true;
                }
                if (Regija.jeCestaIliCilj(regija.TipDole))
                {
                    trotStranaD = true;
                }
                if (Regija.jeCestaIliCilj(regija.TipLijevo))
                {
                    trotStranaL = true;
                }
                if (Regija.jeCestaIliCilj(regija.TipDesno))
                {
                    trotStranaR = true;
                }

                //gledanje coshkova kako na kojem skrece
                //gornji desni
                if (trotCosakUR)
                {
                    if (trotStranaU && trotStranaR)
                    {
                        polje[pX + 7,pY + 0] = -1;
                        polje[pX + 6,pY + 1] = 1;
                    }
                    else if (!trotStranaU && !trotStranaR)
                    {
                        polje[pX + 7, pY + 0] = 1;
                        polje[pX + 6, pY + 1] = -1;
                    }
                }
                //gornji lijevi
                if (trotCosakUL)
                {
                    if (trotStranaU && trotStranaL)
                    {
                        polje[pX + 0, pY + 0] = -1;
                        polje[pX + 1, pY + 1] = 1;
                    }
                    else if (!trotStranaU && !trotStranaL)
                    {
                        polje[pX + 0, pY + 0] = 1;
                        polje[pX + 1, pY + 1] = -1;
                    }
                }
                //donji desni
                if (trotCosakDR)
                {
                    if (trotStranaD && trotStranaR)
                    {
                        polje[pX + 7, pY + 7] = -1;
                        polje[pX + 6, pY + 6] = 1;
                    }
                    else if (!trotStranaD && !trotStranaR)
                    {
                        polje[pX + 7, pY + 7] = 1;
                        polje[pX + 6, pY + 6] = -1;
                    }
                }
                //donji lijevi
                if (trotCosakDL)
                {
                    if (trotStranaD && trotStranaL)
                    {
                        polje[pX + 0, pY + 7] = -1;
                        polje[pX + 1, pY + 6] = 1;
                    }
                    else if (!trotStranaD && !trotStranaL)
                    {
                        polje[pX + 0, pY + 7] = 1;
                        polje[pX + 1, pY + 6] = -1;
                    }
                }

            }
        }
    }
}
