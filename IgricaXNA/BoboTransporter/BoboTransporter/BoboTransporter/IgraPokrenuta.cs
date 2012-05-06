using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using BoboTransporter.EngineTools;
using BoboTransporter.Mapa;

namespace BoboTransporter
{
    class IgraPokrenuta
    {
        private Mapa.Mapa mapa;

        internal Mapa.Mapa Mapa
        {
            get { return mapa; }
            set { mapa = value; }
        }
        private Mapa.KontrolerAuta kontrolerAuta;
        private Mapa.KontrolerPjeshaka kontrolerPjeshaka;
        BoboTransporter.Grafika.Vozila.MojBus mojBus;
        List<BoboTransporter.Grafika.Vozila.Auto> auta;
        List<BoboTransporter.Grafika.Vozila.Pjeshak> pjeshaci;
        float zumiranje;
        Vector2 pozicijaKamere;
        Grafika.Brzinomjer brzinomjer;
        Grafika.Minimapa minimapa;
        Grafika.VrijemeBrojac vrijemeBrojac;
        bool pauziraj;

        public IgraPokrenuta(int sirina, int visina, bool snijeg)
        {
            mapa = new Mapa.Mapa(sirina, visina, snijeg);
            pauziraj = false;
            brzinomjer = new Grafika.Brzinomjer();
            minimapa = new Grafika.Minimapa();
            vrijemeBrojac = new Grafika.VrijemeBrojac();
            vrijemeBrojac.resetujBrojac();

            kontrolerAuta = new Mapa.KontrolerAuta(mapa);
            kontrolerPjeshaka = new Mapa.KontrolerPjeshaka(mapa);

            pozicijaKamere = new Vector2(0, 0);
            zumiranje = 3f;
            mojBus = new Grafika.Vozila.MojBus(sirina / 2, visina / 2);

            //smjesti auta
            auta = new List<BoboTransporter.Grafika.Vozila.Auto>();
            pjeshaci = new List<Grafika.Vozila.Pjeshak>();
            Random rand = new Random();
            foreach (BoboTransporter.Mapa.Regija regija in mapa.Blok)
            {


                if (regija.Tip == TipRegije.CESTAhorizontalna)
                {
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4 - 15, regija.PozYUMapi * 4 - 16, 3, rand.Next() % 8 + 2));
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4 - 14, regija.PozYUMapi * 4 - 13, 1, rand.Next() % 8 + 2));
                }
                else if (regija.Tip == TipRegije.CESTAvertikalna)
                {
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4 - 16, regija.PozYUMapi * 4 - 15, 2, rand.Next() % 8 + 2));
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4 - 13, regija.PozYUMapi * 4 - 14, 0, rand.Next() % 8 + 2));
                }



                if (!Regija.jeCestaIliCilj(regija.Tip))
                {
                    if (Regija.jeCestaIliCilj(regija.TipGore))
                    {
                        if (rand.Next() % 3 == 0)
                        {
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 3, regija.PozYUMapi * 8 - 32, 3, rand.Next() % 8 + 1));
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 5, regija.PozYUMapi * 8 - 32 + 1, 1, rand.Next() % 8 + 1));
                        }

                    }
                    if (Regija.jeCestaIliCilj(regija.TipDole))
                    {
                        if (rand.Next() % 3 == 0)
                        {
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 4, regija.PozYUMapi * 8 - 32 + 7, 1, rand.Next() % 8 + 1));
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 4, regija.PozYUMapi * 8 - 32 + 6, 3, rand.Next() % 8 + 1));
                        }
                    }
                    if (Regija.jeCestaIliCilj(regija.TipLijevo))
                    {
                        if (rand.Next() % 3 == 0)
                        {
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32, regija.PozYUMapi * 8 - 32 + 3, 2, rand.Next() % 8 + 1));
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 1, regija.PozYUMapi * 8 - 32 + 5, 0, rand.Next() % 8 + 1));
                        }
                    }
                    if (Regija.jeCestaIliCilj(regija.TipDesno))
                    {
                        if (rand.Next() % 3 == 0)
                        {
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 7, regija.PozYUMapi * 8 - 32 + 4, 0, rand.Next() % 8 + 1));
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 6, regija.PozYUMapi * 8 - 32 + 4, 2, rand.Next() % 8 + 1));
                        }
                    }
                }
            }

        }

        public IgraPokrenuta(int sirina, int visina, bool snijeg, Mapa.Mapa mapa_)
        {
            mapa = mapa_;

            brzinomjer = new Grafika.Brzinomjer();
            minimapa = new Grafika.Minimapa();
            vrijemeBrojac = new Grafika.VrijemeBrojac();
            vrijemeBrojac.resetujBrojac();

            kontrolerAuta = new Mapa.KontrolerAuta(mapa);
            kontrolerPjeshaka = new Mapa.KontrolerPjeshaka(mapa);

            pozicijaKamere = new Vector2(0, 0);
            zumiranje = 3f;
            mojBus = new Grafika.Vozila.MojBus(sirina / 2, visina / 2);

            //smjesti auta
            auta = new List<BoboTransporter.Grafika.Vozila.Auto>();
            pjeshaci = new List<Grafika.Vozila.Pjeshak>();
            Random rand = new Random();
            foreach (BoboTransporter.Mapa.Regija regija in mapa.Blok)
            {


                if (regija.Tip == TipRegije.CESTAhorizontalna)
                {
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4 - 15, regija.PozYUMapi * 4 - 16, 3, rand.Next() % 8 + 2));
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4 - 14, regija.PozYUMapi * 4 - 13, 1, rand.Next() % 8 + 2));
                }
                else if (regija.Tip == TipRegije.CESTAvertikalna)
                {
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4 - 16, regija.PozYUMapi * 4 - 15, 2, rand.Next() % 8 + 2));
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4 - 13, regija.PozYUMapi * 4 - 14, 0, rand.Next() % 8 + 2));
                }



                if (!Regija.jeCestaIliCilj(regija.Tip))
                {
                    if (Regija.jeCestaIliCilj(regija.TipGore))
                    {
                        if (rand.Next() % 3 == 0)
                        {
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 3, regija.PozYUMapi * 8 - 32, 3, rand.Next() % 8 + 1));
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 5, regija.PozYUMapi * 8 - 32 + 1, 1, rand.Next() % 8 + 1));
                        }

                    }
                    if (Regija.jeCestaIliCilj(regija.TipDole))
                    {
                        if (rand.Next() % 3 == 0)
                        {
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 4, regija.PozYUMapi * 8 - 32 + 7, 1, rand.Next() % 8 + 1));
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 4, regija.PozYUMapi * 8 - 32 + 6, 3, rand.Next() % 8 + 1));
                        }
                    }
                    if (Regija.jeCestaIliCilj(regija.TipLijevo))
                    {
                        if (rand.Next() % 3 == 0)
                        {
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32, regija.PozYUMapi * 8 - 32 + 3, 2, rand.Next() % 8 + 1));
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 1, regija.PozYUMapi * 8 - 32 + 5, 0, rand.Next() % 8 + 1));
                        }
                    }
                    if (Regija.jeCestaIliCilj(regija.TipDesno))
                    {
                        if (rand.Next() % 3 == 0)
                        {
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 7, regija.PozYUMapi * 8 - 32 + 4, 0, rand.Next() % 8 + 1));
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 6, regija.PozYUMapi * 8 - 32 + 4, 2, rand.Next() % 8 + 1));
                        }
                    }
                }
            }

        }


        public virtual void LoadContent(ContentManager theContentManager)
        {
            mapa.LoadContent(theContentManager);
            mojBus.LoadContent(theContentManager);
            brzinomjer.LoadContent(theContentManager);
            minimapa.LoadContent(theContentManager);
            vrijemeBrojac.LoadContent(theContentManager);
            foreach (BoboTransporter.Grafika.Vozila.Auto auto in auta)
            {
                auto.LoadContent(theContentManager);
            }
            foreach (BoboTransporter.Grafika.Vozila.Pjeshak pjeshak in pjeshaci)
            {
                pjeshak.LoadContent(theContentManager);
            }
        }

        public void Update(GameTime gameTime, GraphicsDevice graphicsDevice, SpriteBatch theSpriteBatch)
        {
            vrijemeBrojac.Update(gameTime);

            UpdateKontrola(gameTime);
            foreach (BoboTransporter.Grafika.Vozila.Auto auto in auta)
            {
                try
                {
                    auto.postaviKretanje(kontrolerAuta.Polje[auto.PozicijaCelijeX, auto.PozicijaCelijeY]);
                    auto.Update(gameTime);
                }
                catch
                {
                    Console.WriteLine("Auto crash {0} {1}", auto.PozicijaCelijeX, auto.PozicijaCelijeY);
                }
                
            }
            foreach (BoboTransporter.Grafika.Vozila.Pjeshak pjeshak in pjeshaci)
            {
                try
                {
                    pjeshak.postaviKretanje(kontrolerPjeshaka.Polje[(int)pjeshak.PozicijaCelijeX+8, (int)pjeshak.PozicijaCelijeY+8]);
                    pjeshak.Update(gameTime);
                }
                catch
                {
                    Console.WriteLine("Pjeshak crash {0} {1}", pjeshak.PozicijaCelijeX, pjeshak.PozicijaCelijeY);
                }
            }
            mojBus.Update(gameTime);
            //zumiranje na osnovu brzine busa
            zumiranje = dajZoom(mojBus.Brzina);
            //provjera da li se sudario sa trotoarom
            Console.WriteLine();
            if (sudarSaCiljem())
            {
                Opcije.gamePointer.stanje = StanjeIgre.WIN_MENI;
                Opcije.gamePointer.loadaj = true;
                uzimanjeScreenshotaZaPozadinu(gameTime, graphicsDevice, theSpriteBatch);
            }
            if (sudarSaTrotoarom())
            {

                Opcije.gamePointer.stanje = StanjeIgre.LOSE_MENI;
                Opcije.gamePointer.loadaj = true;
                uzimanjeScreenshotaZaPozadinu(gameTime, graphicsDevice, theSpriteBatch);
            }
            foreach (Grafika.Vozila.Pjeshak pjeshak in pjeshaci)
            {
                if (sudarSaPjeshakom(pjeshak))
                {
                    Opcije.gamePointer.stanje = StanjeIgre.LOSE_MENI;
                    Opcije.gamePointer.loadaj = true;
                    uzimanjeScreenshotaZaPozadinu(gameTime, graphicsDevice, theSpriteBatch);
                }
            }
            foreach (Grafika.Vozila.Auto auto in auta)
            {
                if (sudarSaAutom(auto))
                {
                    Opcije.gamePointer.stanje = StanjeIgre.LOSE_MENI;
                    Opcije.gamePointer.loadaj = true;
                    uzimanjeScreenshotaZaPozadinu(gameTime, graphicsDevice, theSpriteBatch);
                }
            }
            if (pauziraj)
            {
                pauziraj = false;
                Opcije.gamePointer.stanje = StanjeIgre.PAUZA_MENI;
                Opcije.gamePointer.loadaj = true;
                uzimanjeScreenshotaZaPozadinu(gameTime, graphicsDevice, theSpriteBatch);
            }
        }

        private void uzimanjeScreenshotaZaPozadinu(GameTime gameTime, GraphicsDevice graphicsDevice, SpriteBatch theSpriteBatch)
        {
            RenderTarget2D renderTarget = new RenderTarget2D(graphicsDevice, graphicsDevice.Viewport.Width, graphicsDevice.Viewport.Height);
            graphicsDevice.SetRenderTarget(renderTarget);
            Draw(gameTime, theSpriteBatch, new Vector2(graphicsDevice.Viewport.Width / 2, graphicsDevice.Viewport.Height / 2));
            graphicsDevice.SetRenderTarget(null);
            int[] podaci = new int[graphicsDevice.Viewport.Width * graphicsDevice.Viewport.Height];
            renderTarget.GetData<int>(podaci);
            Opcije.pozadina = new Texture2D(graphicsDevice, graphicsDevice.Viewport.Width, graphicsDevice.Viewport.Height);
            Opcije.pozadina.SetData<int>(podaci);
        }

        private float dajZoom(float brzinaBusa)
        {
            return Math.Max(3f/(float)Math.Exp(Math.Abs(brzinaBusa) * 5),1f);
        }

        private void UpdateKontrola(GameTime gameTime)
        {
            InputHandler.Update(gameTime);
            if (!InputHandler.Naprijed && !InputHandler.Nazad)
            {
                mojBus.pustenGasMijenjajBrzinu(gameTime);
            }
            if (InputHandler.Naprijed && !InputHandler.Nazad)
            {
                mojBus.ubrzavaj(gameTime);
            }
            if (InputHandler.Nazad && !InputHandler.Naprijed)
            {
                mojBus.usporavaj(gameTime);
            }
            if (!InputHandler.Lijevo && !InputHandler.Desno)
            {
                mojBus.neSkreci(gameTime);
            }
            if (InputHandler.Lijevo && !InputHandler.Desno)
            {
                mojBus.skreciLijevo(gameTime);
            }
            if (InputHandler.Desno && !InputHandler.Lijevo)
            {
                mojBus.skreciDesno(gameTime);
            }
            if (InputHandler.Exit)
            {
                pauziraj = true;
            }
        }
        public virtual void Draw(GameTime gameTime, SpriteBatch theSpriteBatch, Vector2 sredinaEkrana)
        {
            theSpriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend);
            DrawGame(gameTime, theSpriteBatch, new Vector2(sredinaEkrana.X, sredinaEkrana.Y));
            theSpriteBatch.End();

            theSpriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend);
            DrawHUD(gameTime, theSpriteBatch, new Vector2(sredinaEkrana.X, sredinaEkrana.Y));
            theSpriteBatch.End();

        }

        public virtual void DrawGame(GameTime gameTime, SpriteBatch theSpriteBatch, Vector2 sredinaEkrana)
        {

            //postavi kameru na tacno mjesto
            pozicijaKamere = mojBus.smjestiKameru();

            //odredimo polje u kojem je kamera
            int kameraX = (int)(pozicijaKamere.X / 150f);
            int kameraY = (int)(pozicijaKamere.Y / 150f);
            mapa.Draw(theSpriteBatch,pozicijaKamere, sredinaEkrana, zumiranje,kameraX-5,kameraX+6,kameraY-4,kameraY+5);
            mojBus.Draw(theSpriteBatch, pozicijaKamere, sredinaEkrana, zumiranje);
            foreach (BoboTransporter.Grafika.Vozila.Auto auto in auta)
            {
                float daljina = Vector2.Distance(auto.Pozicija,mojBus.Pozicija);
                if (daljina<1500f)
                auto.Draw(theSpriteBatch, pozicijaKamere, sredinaEkrana, zumiranje);
            }
            foreach (BoboTransporter.Grafika.Vozila.Pjeshak pjeshak in pjeshaci)
            {
                float daljina = Vector2.Distance(pjeshak.Pozicija, mojBus.Pozicija);
                if (daljina < 1500f)
                pjeshak.Draw(theSpriteBatch, pozicijaKamere, sredinaEkrana, zumiranje);
            }
        }

        public virtual void DrawHUD(GameTime gameTime, SpriteBatch theSpriteBatch, Vector2 sredinaEkrana)
        {

            if (Opcije.brzinomjerUkljucen) brzinomjer.Draw(theSpriteBatch, sredinaEkrana, mojBus.Brzina);
            if (Opcije.mapaUkljucena) minimapa.Draw(theSpriteBatch, sredinaEkrana, mapa,mojBus.Pozicija);
            if (Opcije.vrijemeUkljuceno) vrijemeBrojac.Draw(theSpriteBatch, sredinaEkrana);

        }

        private bool sudarSaTrotoarom()
        {
            float dimenzija = 10f;
            if (tackaNaTrotoaru(mojBus.Pozicija.X, mojBus.Pozicija.Y)) return true;
            if (tackaNaTrotoaru(mojBus.Pozicija.X + dimenzija, mojBus.Pozicija.Y)) return true;
            if (tackaNaTrotoaru(mojBus.Pozicija.X - dimenzija, mojBus.Pozicija.Y)) return true;
            if (tackaNaTrotoaru(mojBus.Pozicija.X, mojBus.Pozicija.Y + dimenzija)) return true;
            if (tackaNaTrotoaru(mojBus.Pozicija.X, mojBus.Pozicija.Y - dimenzija)) return true;
            if (tackaNaTrotoaru(mojBus.Pozicija.X + dimenzija * 0.7f, mojBus.Pozicija.Y + dimenzija * 0.7f)) return true;
            if (tackaNaTrotoaru(mojBus.Pozicija.X - dimenzija * 0.7f, mojBus.Pozicija.Y + dimenzija * 0.7f)) return true;
            if (tackaNaTrotoaru(mojBus.Pozicija.X + dimenzija * 0.7f, mojBus.Pozicija.Y - dimenzija * 0.7f)) return true;
            if (tackaNaTrotoaru(mojBus.Pozicija.X - dimenzija * 0.7f, mojBus.Pozicija.Y - dimenzija * 0.7f)) return true;
            return false;
        }

        private bool sudarSaCiljem()
        {
            float dimenzija = 10f;
            if (nijeTackaNaCilju(mojBus.Pozicija.X, mojBus.Pozicija.Y)) return false;
            if (nijeTackaNaCilju(mojBus.Pozicija.X + dimenzija, mojBus.Pozicija.Y)) return false;
            if (nijeTackaNaCilju(mojBus.Pozicija.X - dimenzija, mojBus.Pozicija.Y)) return false;
            if (nijeTackaNaCilju(mojBus.Pozicija.X, mojBus.Pozicija.Y + dimenzija)) return false;
            if (nijeTackaNaCilju(mojBus.Pozicija.X, mojBus.Pozicija.Y - dimenzija)) return false;
            if (nijeTackaNaCilju(mojBus.Pozicija.X + dimenzija * 0.7f, mojBus.Pozicija.Y + dimenzija * 0.7f)) return false;
            if (nijeTackaNaCilju(mojBus.Pozicija.X - dimenzija * 0.7f, mojBus.Pozicija.Y + dimenzija * 0.7f)) return false;
            if (nijeTackaNaCilju(mojBus.Pozicija.X + dimenzija * 0.7f, mojBus.Pozicija.Y - dimenzija * 0.7f)) return false;
            if (nijeTackaNaCilju(mojBus.Pozicija.X - dimenzija * 0.7f, mojBus.Pozicija.Y - dimenzija * 0.7f)) return false;
            return true;
        }

        private bool sudarSaPjeshakom(Grafika.Vozila.Pjeshak pjeshak)
        {
            List<Vector3> krugoviBus = new List<Vector3>();
            List<Vector3> krugoviPjeshak = new List<Vector3>();

            krugoviBus.Add(new Vector3(mojBus.Pozicija.X + mojBus.Velicina * 25f * (float)Math.Sin(mojBus.Rotacija), mojBus.Pozicija.Y - mojBus.Velicina * 25f * (float)Math.Cos(mojBus.Rotacija), mojBus.Velicina * 50f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X - mojBus.Velicina * 25f * (float)Math.Sin(mojBus.Rotacija), mojBus.Pozicija.Y + mojBus.Velicina * 25f * (float)Math.Cos(mojBus.Rotacija), mojBus.Velicina * 50f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X + mojBus.Velicina * 75f * (float)Math.Sin(mojBus.Rotacija), mojBus.Pozicija.Y - mojBus.Velicina * 75f * (float)Math.Cos(mojBus.Rotacija), mojBus.Velicina * 50f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X - mojBus.Velicina * 75f * (float)Math.Sin(mojBus.Rotacija), mojBus.Pozicija.Y + mojBus.Velicina * 75f * (float)Math.Cos(mojBus.Rotacija), mojBus.Velicina * 50f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X + mojBus.Velicina * 100f * (float)Math.Sin(mojBus.Rotacija) + mojBus.Velicina * 25f * (float)Math.Cos(mojBus.Rotacija),
                mojBus.Pozicija.Y - mojBus.Velicina * 100f * (float)Math.Cos(mojBus.Rotacija) - mojBus.Velicina * 25f * (float)Math.Sin(mojBus.Rotacija),
                mojBus.Velicina * 25f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X - mojBus.Velicina * 100f * (float)Math.Sin(mojBus.Rotacija) + mojBus.Velicina * 25f * (float)Math.Cos(mojBus.Rotacija),
                mojBus.Pozicija.Y + mojBus.Velicina * 100f * (float)Math.Cos(mojBus.Rotacija) - mojBus.Velicina * 25f * (float)Math.Sin(mojBus.Rotacija),
                mojBus.Velicina * 25f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X + mojBus.Velicina * 100f * (float)Math.Sin(mojBus.Rotacija) - mojBus.Velicina * 25f * (float)Math.Cos(mojBus.Rotacija),
                mojBus.Pozicija.Y - mojBus.Velicina * 100f * (float)Math.Cos(mojBus.Rotacija) + mojBus.Velicina * 25f * (float)Math.Sin(mojBus.Rotacija),
                mojBus.Velicina * 25f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X - mojBus.Velicina * 100f * (float)Math.Sin(mojBus.Rotacija) - mojBus.Velicina * 25f * (float)Math.Cos(mojBus.Rotacija),
                mojBus.Pozicija.Y + mojBus.Velicina * 100f * (float)Math.Cos(mojBus.Rotacija) + mojBus.Velicina * 25f * (float)Math.Sin(mojBus.Rotacija),
                mojBus.Velicina * 25f));


            //(0,0,20)
            //(-30,-5,15)
            //(30,-5,15)
            krugoviPjeshak.Add(new Vector3(pjeshak.Pozicija.X, pjeshak.Pozicija.Y, pjeshak.Velicina * 20f));
            krugoviPjeshak.Add(new Vector3(pjeshak.Pozicija.X - pjeshak.Velicina * 5f * (float)Math.Sin(pjeshak.Rotacija) + pjeshak.Velicina * 30f * (float)Math.Cos(pjeshak.Rotacija),
                pjeshak.Pozicija.Y + pjeshak.Velicina * 5f * (float)Math.Cos(pjeshak.Rotacija) - pjeshak.Velicina * 30f * (float)Math.Sin(pjeshak.Rotacija),
                pjeshak.Velicina * 15f));
            krugoviPjeshak.Add(new Vector3(pjeshak.Pozicija.X - pjeshak.Velicina * 5f * (float)Math.Sin(pjeshak.Rotacija) - pjeshak.Velicina * 30f * (float)Math.Cos(pjeshak.Rotacija),
                pjeshak.Pozicija.Y + pjeshak.Velicina * 5f * (float)Math.Cos(pjeshak.Rotacija) + pjeshak.Velicina * 30f * (float)Math.Sin(pjeshak.Rotacija),
                pjeshak.Velicina * 15f));

            foreach (Vector3 krugAuta in krugoviPjeshak)
                foreach (Vector3 krugBusa in krugoviBus)
                {
                    if ((krugAuta.X - krugBusa.X) * (krugAuta.X - krugBusa.X) + (krugAuta.Y - krugBusa.Y) * (krugAuta.Y - krugBusa.Y) < (krugAuta.Z + krugBusa.Z) * (krugAuta.Z + krugBusa.Z)) return true;
                }

            return false;
        }

        private bool sudarSaAutom(Grafika.Vozila.Auto auto)
        {
            //return provjeriSudarKutija(mojBus.Pozicija,mojBus.Rotacija,100f*mojBus.Velicina,250f*mojBus.Velicina, auto.Pozicija,auto.Rotacija, 150f*auto.Velicina,250f*auto.Velicina);

            List<Vector3> krugoviBus = new List<Vector3>();
            List<Vector3> krugoviAuto = new List<Vector3>();

            krugoviBus.Add(new Vector3(mojBus.Pozicija.X + mojBus.Velicina * 25f * (float)Math.Sin(mojBus.Rotacija), mojBus.Pozicija.Y - mojBus.Velicina * 25f * (float)Math.Cos(mojBus.Rotacija), mojBus.Velicina * 50f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X - mojBus.Velicina * 25f * (float)Math.Sin(mojBus.Rotacija), mojBus.Pozicija.Y + mojBus.Velicina * 25f * (float)Math.Cos(mojBus.Rotacija), mojBus.Velicina * 50f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X + mojBus.Velicina * 75f * (float)Math.Sin(mojBus.Rotacija), mojBus.Pozicija.Y - mojBus.Velicina * 75f * (float)Math.Cos(mojBus.Rotacija), mojBus.Velicina * 50f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X - mojBus.Velicina * 75f * (float)Math.Sin(mojBus.Rotacija), mojBus.Pozicija.Y + mojBus.Velicina * 75f * (float)Math.Cos(mojBus.Rotacija), mojBus.Velicina * 50f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X + mojBus.Velicina * 100f * (float)Math.Sin(mojBus.Rotacija) + mojBus.Velicina * 25f * (float)Math.Cos(mojBus.Rotacija),
                mojBus.Pozicija.Y - mojBus.Velicina * 100f * (float)Math.Cos(mojBus.Rotacija) - mojBus.Velicina * 25f * (float)Math.Sin(mojBus.Rotacija),
                mojBus.Velicina * 25f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X - mojBus.Velicina * 100f * (float)Math.Sin(mojBus.Rotacija) + mojBus.Velicina * 25f * (float)Math.Cos(mojBus.Rotacija),
                mojBus.Pozicija.Y + mojBus.Velicina * 100f * (float)Math.Cos(mojBus.Rotacija) - mojBus.Velicina * 25f * (float)Math.Sin(mojBus.Rotacija),
                mojBus.Velicina * 25f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X + mojBus.Velicina * 100f * (float)Math.Sin(mojBus.Rotacija) - mojBus.Velicina * 25f * (float)Math.Cos(mojBus.Rotacija),
                mojBus.Pozicija.Y - mojBus.Velicina * 100f * (float)Math.Cos(mojBus.Rotacija) + mojBus.Velicina * 25f * (float)Math.Sin(mojBus.Rotacija),
                mojBus.Velicina * 25f));
            krugoviBus.Add(new Vector3(mojBus.Pozicija.X - mojBus.Velicina * 100f * (float)Math.Sin(mojBus.Rotacija) - mojBus.Velicina * 25f * (float)Math.Cos(mojBus.Rotacija),
                mojBus.Pozicija.Y + mojBus.Velicina * 100f * (float)Math.Cos(mojBus.Rotacija) + mojBus.Velicina * 25f * (float)Math.Sin(mojBus.Rotacija),
                mojBus.Velicina * 25f));

            krugoviAuto.Add(new Vector3(auto.Pozicija.X, auto.Pozicija.Y, auto.Velicina * 75f));
            krugoviAuto.Add(new Vector3(auto.Pozicija.X + auto.Velicina * 50f * (float)Math.Sin(auto.Rotacija), auto.Pozicija.Y - auto.Velicina * 50f * (float)Math.Cos(auto.Rotacija), auto.Velicina * 75f));
            krugoviAuto.Add(new Vector3(auto.Pozicija.X - auto.Velicina * 50f * (float)Math.Sin(auto.Rotacija), auto.Pozicija.Y + auto.Velicina * 50f * (float)Math.Cos(auto.Rotacija), auto.Velicina * 75f));
            krugoviAuto.Add(new Vector3(auto.Pozicija.X + auto.Velicina * 100f * (float)Math.Sin(auto.Rotacija) + auto.Velicina * 50f * (float)Math.Cos(auto.Rotacija),
                auto.Pozicija.Y - auto.Velicina * 100f * (float)Math.Cos(auto.Rotacija) - auto.Velicina * 50f * (float)Math.Sin(auto.Rotacija),
                auto.Velicina * 25f));
            krugoviAuto.Add(new Vector3(auto.Pozicija.X - auto.Velicina * 100f * (float)Math.Sin(auto.Rotacija) + auto.Velicina * 50f * (float)Math.Cos(auto.Rotacija),
                auto.Pozicija.Y + auto.Velicina * 100f * (float)Math.Cos(auto.Rotacija) - auto.Velicina * 50f * (float)Math.Sin(auto.Rotacija),
                auto.Velicina * 25f));
            krugoviAuto.Add(new Vector3(auto.Pozicija.X + auto.Velicina * 100f * (float)Math.Sin(auto.Rotacija) - auto.Velicina * 50f * (float)Math.Cos(auto.Rotacija),
                auto.Pozicija.Y - auto.Velicina * 100f * (float)Math.Cos(auto.Rotacija) + auto.Velicina * 50f * (float)Math.Sin(auto.Rotacija),
                auto.Velicina * 25f));
            krugoviAuto.Add(new Vector3(auto.Pozicija.X - auto.Velicina * 100f * (float)Math.Sin(auto.Rotacija) - auto.Velicina * 50f * (float)Math.Cos(auto.Rotacija),
                auto.Pozicija.Y + auto.Velicina * 100f * (float)Math.Cos(auto.Rotacija) + auto.Velicina * 50f * (float)Math.Sin(auto.Rotacija),
                auto.Velicina * 25f));

            foreach (Vector3 krugAuta in krugoviAuto)
                foreach (Vector3 krugBusa in krugoviBus)
                {
                    if ((krugAuta.X - krugBusa.X) * (krugAuta.X - krugBusa.X) + (krugAuta.Y - krugBusa.Y) * (krugAuta.Y - krugBusa.Y) < (krugAuta.Z + krugBusa.Z) * (krugAuta.Z + krugBusa.Z)) return true;
                }

            return false;

        }

        private static bool suprotne(float t1, float ts, float t2)
        {
            if ((t1 - ts < 0.0001f) && (ts - t2 < 0.0001f)) return true;
            if ((t1 - ts < 0.0001f) && (ts - t2 < 0.0001f)) return true;
            return false;
        }

        private bool tackaNaTrotoaru(float posX, float posY)
        {
            return (!Regija.jeProhodnaCestaIliCilj(mapa.Blok[(int)(posX) / 150, (int)(posY) / 150].Tip));
        }

        private bool nijeTackaNaCilju(float posX, float posY)
        {
            return (mapa.Blok[(int)(posX) / 150, (int)(posY) / 150].Tip!=TipRegije.CILJ);
        }

    }
}
