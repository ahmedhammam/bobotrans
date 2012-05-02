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

        public TipRegije Tip
        {
            get { return tip; }
            set { tip = value; }
        }
        private TipRegije tipGore;

        public TipRegije TipGore
        {
            get { return tipGore; }
            set { tipGore = value; }
        }
        private TipRegije tipDole;

        public TipRegije TipDole
        {
            get { return tipDole; }
            set { tipDole = value; }
        }
        private TipRegije tipDesno;

        public TipRegije TipDesno
        {
            get { return tipDesno; }
            set { tipDesno = value; }
        }
        private TipRegije tipLijevo;

        public TipRegije TipLijevo
        {
            get { return tipLijevo; }
            set { tipLijevo = value; }
        }
        private TipRegije tipGoreDesno;

        public TipRegije TipGoreDesno
        {
            get { return tipGoreDesno; }
            set { tipGoreDesno = value; }
        }
        private TipRegije tipGoreLijevo;

        public TipRegije TipGoreLijevo
        {
            get { return tipGoreLijevo; }
            set { tipGoreLijevo = value; }
        }
        private TipRegije tipDoleDesno;

        public TipRegije TipDoleDesno
        {
            get { return tipDoleDesno; }
            set { tipDoleDesno = value; }
        }
        private TipRegije tipDoleLijevo;

        public TipRegije TipDoleLijevo
        {
            get { return tipDoleLijevo; }
            set { tipDoleLijevo = value; }
        }

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

        public void generishi(int randSeed)
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


                    if (tip == TipRegije.ZEMLJA)
                    {
                        Zemlja b;
                        b = new Zemlja();
                        b.Pozicija = new Vector2(75f, 75f);
                        slicice.Add(b);
                        Random rand = new Random(randSeed);
                        if (rand.Next() % 3 != 0)
                        {
                            //posadi drvo
                            Drvo c;
                            c = new Drvo();
                            c.Pozicija = new Vector2((float)(rand.NextDouble() * 75 + 37.5), (float)(rand.NextDouble() * 75 + 37.5));
                            c.Velicina *= (float)(rand.NextDouble() * 0.8 + 0.8);
                            c.Rotacija = (float)(rand.NextDouble() * Math.PI * 2);
                            slicice.Add(c);
                        }
                        if (rand.Next() % 3 != 0)
                        {
                            //dodaj kamenje
                            int brKamenja = rand.Next() % 3 + 1;
                            Kamen k;
                            for (int i = 0; i < brKamenja; i++)
                            {
                                k = new Kamen(rand.Next()%6+1);
                                k.Pozicija = new Vector2((float)(rand.NextDouble() * 50 + 50), (float)(rand.NextDouble() * 50 + 50));
                                k.Velicina *= (float)(rand.NextDouble() * 0.5 + 0.5);
                                k.Rotacija = (float)(rand.NextDouble() * Math.PI * 2);
                                slicice.Add(k);
                            }
                        }
                        
                    }
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

        public static bool jeCesta(TipRegije tip2)
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

        public static bool jeProhodnaCesta(TipRegije tip2)
        {
            bool blaa;
            blaa = (tip2 == TipRegije.CESTADeadEnd ||
                tip2 == TipRegije.CESTAhorizontalna ||
                tip2 == TipRegije.CESTAvertikalna ||
                tip2 == TipRegije.RASKRSNICA ||
                tip2 == TipRegije.SKRETANJE);
            return blaa;
        }

        public static bool jeCestaIliCilj(TipRegije tip2)
        {
            return (jeCesta(tip2) || tip2==TipRegije.CILJ);
        }

        public static bool jeProhodnaCestaIliCilj(TipRegije tip2)
        {
            return (jeProhodnaCesta(tip2) || tip2 == TipRegije.CILJ);
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
