using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Mapa
{
    class Mapa
    {
        private int sirina;

        public int Sirina
        {
            get { return sirina; }
            set { sirina = value; }
        }

        private int visina;

        public int Visina
        {
            get { return visina; }
            set { visina = value; }
        }

        private GenerisanjeLabirinta.Labirint lab;
        private Regija[,] blok;

        internal Regija[,] Blok
        {
            get { return blok; }
            set { blok = value; }
        }
        public Mapa(int velX, int velY,bool snijeg)
        {
            Grafika.Drvo.resetujBrojacDrveca();
            Grafika.Kamen.resetujBrojacKamenja();
            TipRegije okolina;
            if (snijeg) okolina = TipRegije.SNIJEG;
            else okolina = TipRegije.ZEMLJA;
            lab = new GenerisanjeLabirinta.Labirint(velX, velY);
            lab.Generishi();
            sirina = velX * 2 + 9;
            visina = velY * 2 + 9;
            TipRegije[,] tipoviRegija = new TipRegije[sirina+2, visina+2];
            blok = new Regija[sirina, visina];

            #region PostavljanjeTipovaRegija
            for (int i = 0; i < sirina + 2; i++)
                for (int j = 0; j < visina + 2; j++)
                {
                    tipoviRegija[i, j] = okolina;
                }
            for (int i = 0; i < lab.Sirina*2+1; i++)
                for (int j = 0; j < lab.Visina*2+1; j++)
                {
                    /*
                      * u ovim poljima ce cuvati podatke o poljima labirinta, i to su:
                      * 0 - izlaz iz labirinta
                      * 1 - raskrsnica
                      * 2 - put je provodan
                      * 3 - ne postoji put
                      * 4 - nije put
                      * 8 - nije provodan
                      * 5 - nedefinisano
                      * 6 - nedefinisano i nepogledano
                      * 7 - raskrsnica kojoj nije moguce doci
                      * unosi se X pa Y koordinata
                     */
                    if (lab.Polje[i, j] == '0')
                    {
                        tipoviRegija[i + 5, j + 5] = TipRegije.CILJ;
                    }
                    else if (lab.Polje[i, j] == '1')
                    {
                        //odrediti jel raskrsnica, skretanje, ravan put ili dead end
                        bool cU = (lab.Polje[i, j - 1] == '2' || lab.Polje[i, j - 1] == '8');
                        bool cD = (lab.Polje[i, j + 1] == '2' || lab.Polje[i, j + 1] == '8');
                        bool cL = (lab.Polje[i - 1, j] == '2' || lab.Polje[i - 1, j] == '8');
                        bool cR = (lab.Polje[i + 1, j] == '2' || lab.Polje[i + 1, j] == '8');
                        if (cU && cD && cL && cR)
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.RASKRSNICA;
                        }
                        else if (!cU && cD && cL && cR)
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.RASKRSNICA;
                        }
                        else if (cU && !cD && cL && cR)
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.RASKRSNICA;
                        }
                        else if (cU && cD && !cL && cR)
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.RASKRSNICA;
                        }
                        else if (cU && cD && cL && !cR)
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.RASKRSNICA;
                        }
                        else if (!cU && !cD && cL && cR)
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.CESTAhorizontalna;
                        }
                        else if (cU && cD && !cL && !cR)
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.CESTAvertikalna;
                        }
                        else if (!cU && cD && !cL && cR)
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.SKRETANJE;
                        }
                        else if (!cU && cD && cL && !cR)
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.SKRETANJE;
                        }
                        else if (cU && !cD && !cL && cR)
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.SKRETANJE;
                        }
                        else if (cU && !cD && cL && !cR)
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.SKRETANJE;
                        }
                        else
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.CESTADeadEnd;
                        }
                    }
                    else if (lab.Polje[i, j] == '2')
                    {
                        //odrediti jel horizontalan ili vertikalan
                        if (i % 2 == 0)
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.CESTAhorizontalna;
                        }
                        else
                        {
                            tipoviRegija[i + 5, j + 5] = TipRegije.CESTAvertikalna;
                        }
                    }
                    else if (lab.Polje[i, j] == '3')
                    {
                        tipoviRegija[i + 5, j + 5] = okolina;
                    }
                    else if (lab.Polje[i, j] == '8')
                    {
                        tipoviRegija[i + 5, j + 5] = TipRegije.ZATVORENA_CESTA;
                    }
                } 
            #endregion
            Random rand = new Random();
            for (int i=0;i<sirina;i++)
                for (int j = 0; j < visina; j++)
                {
                    blok[i, j] = new Regija(i, j,
                        tipoviRegija[i + 1, j + 1],
                        tipoviRegija[i + 1, j],
                        tipoviRegija[i + 1, j + 2],
                        tipoviRegija[i, j + 1],
                        tipoviRegija[i + 2, j + 1],
                        tipoviRegija[i + 2, j],
                        tipoviRegija[i, j],
                        tipoviRegija[i + 2, j + 2],
                        tipoviRegija[i, j + 2]);
                    blok[i, j].generishi(rand.Next());
                }
        }


        public void LoadContent(ContentManager theContentManager)
        {
            foreach (Regija a in blok)
            {
                a.LoadContent(theContentManager);
            }
        }

        public void Draw(SpriteBatch theSpriteBatch, Vector2 cameraPosition, Vector2 sredinaEkrana, float zumiranje)
        {
            foreach (Regija a in blok)
            {
                a.Draw(theSpriteBatch, cameraPosition, sredinaEkrana, zumiranje);
            }
        }

        public void Draw(SpriteBatch theSpriteBatch, Vector2 cameraPosition, Vector2 sredinaEkrana, float zumiranje, int minX,int maxX, int minY, int maxY)
        {
            for (int i = Math.Max(minX, 0); i < Math.Min(maxX, sirina); i++)
                for (int j = Math.Max(minY, 0); j < Math.Min(maxY, visina); j++)
            {
                blok[i,j].Draw(theSpriteBatch, cameraPosition, sredinaEkrana, zumiranje);
            }
        }

    }
}
