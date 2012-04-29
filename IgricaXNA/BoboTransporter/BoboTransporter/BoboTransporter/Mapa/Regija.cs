using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using BoboTransporter.Grafika;
using BoboTransporter.Grafika.Podloge;

namespace BoboTransporter.Mapa
{
    class Regija
    {
        //RADIM NA OVOM

        //shirina i visina regije su oboje 150

        List<Slicica> slicice;

        private int pozXUMapi;
        public int PozXUMapi
        {
          get { return pozXUMapi; }
          set { pozXUMapi = value; }
        }

        private int pozYUMapi;
        public int PozYUMapi
        {
          get { return pozYUMapi; }
          set { pozYUMapi = value; }
        }

        private TipRegije tip;
        private TipRegije tipGore;
        private TipRegije tipDole;
        private TipRegije tipDesno;
        private TipRegije tipLijevo;
        private TipRegije tipGoreDesno;
        private TipRegije tipGoreLijevo;
        private TipRegije tipDoleDesno;
        private TipRegije tipDoleLijevo;

        public Regija(int pozX, int pozY, TipRegije tip_, TipRegije tipGore_, TipRegije tipDole_, TipRegije tipLijevo_, TipRegije tipDesno_
                                                        , TipRegije tipGoreDesno_, TipRegije tipGoreLijevo_, TipRegije tipDoleDesno_, TipRegije tipDoleLijevo_)
        {
            pozXUMapi = pozX;
            pozYUMapi = pozY;
            tip = tip_;
            tipGore = tipGore_;
            tipDole = tipDole_;
            tipLijevo = tipLijevo_;
            tipDesno = tipDesno_;
            tipGoreDesno = tipGoreDesno_;
            tipGoreLijevo = tipGoreLijevo_;
            tipDoleDesno = tipDoleDesno_;
            tipDoleLijevo = tipDoleLijevo_;
            slicice = new List<Slicica>();
        }

        public void generishi()
        {
            if (tip == TipRegije.CILJ)
            {
                Cilj a;
                a = new Cilj();
                a.Pozicija = new Vector2(75f, 75f);
                slicice.Add(a);
            }
            else
            {
                //generisanje regije ako joj je tip cesta
                if (jeCesta(tip))
                {
                    //generisanje regije ako joj je tip cesta
                    Asfalt a1;
                    a1 = new Asfalt();
                    a1.Pozicija = new Vector2(75f / 2, 75f / 2);
                    slicice.Add(a1);
                    a1 = new Asfalt();
                    a1.Pozicija = new Vector2(75f / 2 + 75f, 75f / 2);
                    slicice.Add(a1);
                    a1 = new Asfalt();
                    a1.Pozicija = new Vector2(75f / 2, 75f / 2 + 75f);
                    slicice.Add(a1);
                    a1 = new Asfalt();
                    a1.Pozicija = new Vector2(75f / 2 + 75f, 75f / 2 + 75f);
                    slicice.Add(a1);

                    #region CrtanjePoCestama
                    //raskrsnice i zatvorene ceste nemaju sta dalje da se modifikuju

                    if (tip == TipRegije.CESTAhorizontalna)
                    {
                        LinijeNaCesti a;
                        a = new LinijeNaCesti(true);
                        a.Pozicija = new Vector2(75f, 75f);
                        slicice.Add(a);
                        if (tipLijevo == TipRegije.RASKRSNICA)
                        {
                            LinijaStopNaCesti b;
                            b = new LinijaStopNaCesti(3);
                            b.Pozicija = new Vector2(75f, 75f);
                            slicice.Add(b);
                        }
                        if (tipDesno == TipRegije.RASKRSNICA)
                        {
                            LinijaStopNaCesti b;
                            b = new LinijaStopNaCesti(1);
                            b.Pozicija = new Vector2(75f, 75f);
                            slicice.Add(b);
                        }
                    }
                    else if (tip == TipRegije.CESTAvertikalna)
                    {
                        LinijeNaCesti a;
                        a = new LinijeNaCesti(false);
                        a.Pozicija = new Vector2(75f, 75f);
                        slicice.Add(a);
                        if (tipGore == TipRegije.RASKRSNICA)
                        {
                            LinijaStopNaCesti b;
                            b = new LinijaStopNaCesti(0);
                            b.Pozicija = new Vector2(75f, 75f);
                            slicice.Add(b);
                        }
                        if (tipDole == TipRegije.RASKRSNICA)
                        {
                            LinijaStopNaCesti b;
                            b = new LinijaStopNaCesti(2);
                            b.Pozicija = new Vector2(75f, 75f);
                            slicice.Add(b);
                        }
                    }
                    else if (tip == TipRegije.SKRETANJE)
                    {
                        LinijeNaSkretanjuCeste a = new LinijeNaSkretanjuCeste(0);
                        if ((tipGore == TipRegije.CESTAvertikalna || tipGore == TipRegije.ZATVORENA_CESTA) &&
                            (tipDesno == TipRegije.CESTAhorizontalna || tipDesno == TipRegije.ZATVORENA_CESTA))
                        {
                            a = new LinijeNaSkretanjuCeste(3);
                        }
                        else if ((tipGore == TipRegije.CESTAvertikalna || tipGore == TipRegije.ZATVORENA_CESTA) &&
                            (tipLijevo == TipRegije.CESTAhorizontalna || tipLijevo == TipRegije.ZATVORENA_CESTA))
                        {
                            a = new LinijeNaSkretanjuCeste(2);
                        }
                        else if ((tipDole == TipRegije.CESTAvertikalna || tipDole == TipRegije.ZATVORENA_CESTA) &&
                            (tipDesno == TipRegije.CESTAhorizontalna || tipDesno == TipRegije.ZATVORENA_CESTA))
                        {
                            a = new LinijeNaSkretanjuCeste(0);
                        }
                        else if ((tipDole == TipRegije.CESTAvertikalna || tipDole == TipRegije.ZATVORENA_CESTA) &&
                            (tipLijevo == TipRegije.CESTAhorizontalna || tipLijevo == TipRegije.ZATVORENA_CESTA))
                        {
                            a = new LinijeNaSkretanjuCeste(1);
                        }
                        a.Pozicija = new Vector2(75f, 75f);
                        slicice.Add(a);
                    }
                    else if (tip == TipRegije.ZATVORENA_CESTA)
                    {
                        RadoviNaCesti a;
                        a = new RadoviNaCesti();
                        a.Pozicija = new Vector2(75f, 75f);
                        slicice.Add(a);
                    }
                    #endregion

                }

                //gotove ceste, gledamo plocnike
                else
                {
                    //stavljamo trotoare
                    #region StavljanjeTrotoara
                    Trotoar a;
                    if (jeCestaIliCilj(tipDesno) || jeCestaIliCilj(tipGore) || jeCestaIliCilj(tipGoreDesno))
                    {
                        a = new Trotoar();
                        a.Pozicija = new Vector2(150f - 150f / 8, 150f / 8);
                        slicice.Add(a);
                    }
                    if (jeCestaIliCilj(tipLijevo) || jeCestaIliCilj(tipGore) || jeCestaIliCilj(tipGoreLijevo))
                    {
                        a = new Trotoar();
                        a.Pozicija = new Vector2(150f / 8, 150f / 8);
                        slicice.Add(a);
                    }
                    if (jeCestaIliCilj(tipDesno) || jeCestaIliCilj(tipDole) || jeCestaIliCilj(tipDoleDesno))
                    {
                        a = new Trotoar();
                        a.Pozicija = new Vector2(150f - 150f / 8, 150f - 150f / 8);
                        slicice.Add(a);
                    }
                    if (jeCestaIliCilj(tipLijevo) || jeCestaIliCilj(tipDole) || jeCestaIliCilj(tipDoleLijevo))
                    {
                        a = new Trotoar();
                        a.Pozicija = new Vector2(150f / 8, 150f - 150f / 8);
                        slicice.Add(a);
                    }
                    if (jeCestaIliCilj(tipGore))
                    {
                        a = new Trotoar();
                        a.Pozicija = new Vector2(150f / 8 + 150f / 4, 150f / 8);
                        slicice.Add(a);
                        a = new Trotoar();
                        a.Pozicija = new Vector2(150f / 8 + 300f / 4, 150f / 8);
                        slicice.Add(a);
                    }
                    if (jeCestaIliCilj(tipDole))
                    {
                        a = new Trotoar();
                        a.Pozicija = new Vector2(150f / 8 + 150f / 4, 150f - 150f / 8);
                        slicice.Add(a);
                        a = new Trotoar();
                        a.Pozicija = new Vector2(150f / 8 + 300f / 4, 150f - 150f / 8);
                        slicice.Add(a);
                    }
                    if (jeCestaIliCilj(tipLijevo))
                    {
                        a = new Trotoar();
                        a.Pozicija = new Vector2(150f / 8, 150f / 8 + 150f / 4);
                        slicice.Add(a);
                        a = new Trotoar();
                        a.Pozicija = new Vector2(150f / 8, 150f / 8 + 300f / 4);
                        slicice.Add(a);
                    }
                    if (jeCestaIliCilj(tipDesno))
                    {
                        a = new Trotoar();
                        a.Pozicija = new Vector2(150f - 150f / 8, 150f / 8 + 150f / 4);
                        slicice.Add(a);
                        a = new Trotoar();
                        a.Pozicija = new Vector2(150f - 150f / 8, 150f / 8 + 300f / 4);
                        slicice.Add(a);
                    }
                    #endregion
                    //stavljamo travu
                    if (tip == TipRegije.ZEMLJA)
                    {
                        Zemlja b;
                        b = new Zemlja();
                        b.Pozicija = new Vector2(75f, 75f);
                        slicice.Add(b);
                    }

                    //stavljamo ostatak terena
                    if (tip == TipRegije.SNIJEG)
                    {
                        Snijeg b;
                        b = new Snijeg();
                        b.Pozicija = new Vector2(75f, 75f);
                        slicice.Add(b);
                    }
                }
            }

        }

        private static bool jeCesta(TipRegije tip2)
        {
            bool blaa;
            blaa = (tip2 == TipRegije.CESTADeadEnd ||
                tip2 == TipRegije.CESTAhorizontalna ||
                tip2 == TipRegije.CESTAvertikalna ||
                tip2 == TipRegije.RASKRSNICA ||
                tip2 == TipRegije.SKRETANJE ||
                tip2 == TipRegije.ZATVORENA_CESTA);
            return blaa;
        }

        private static bool jeCestaIliCilj(TipRegije tip2)
        {
            return (jeCesta(tip2) || tip2==TipRegije.CILJ);
        }

        public void LoadContent(ContentManager theContentManager)
        {
            foreach (Slicica a in slicice)
            {
                a.LoadContent(theContentManager);
            }
        }

        public void Draw(SpriteBatch theSpriteBatch, Vector2 cameraPosition, Vector2 sredinaEkrana, float zumiranje)
        {
            foreach (Slicica a in slicice)
            {
                a.DrawInRegion(theSpriteBatch, cameraPosition, sredinaEkrana, zumiranje, new Vector2(150f * pozXUMapi, 150f * pozYUMapi));
            }
        }

    }
}
