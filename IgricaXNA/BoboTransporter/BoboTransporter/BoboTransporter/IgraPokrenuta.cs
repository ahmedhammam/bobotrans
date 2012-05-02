using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using BoboTransporter.EngineTools;

namespace BoboTransporter
{
    class IgraPokrenuta
    {
        private Mapa.Mapa mapa;
        private Mapa.KontrolerAuta kontrolerAuta;
        private Mapa.KontrolerPjeshaka kontrolerPjeshaka;
        BoboTransporter.Grafika.Vozila.MojBus mojBus;
        List<BoboTransporter.Grafika.Vozila.Auto> auta;
        List<BoboTransporter.Grafika.Vozila.Pjeshak> pjeshaci;
        float zumiranje;
        Vector2 pozicijaKamere;
        Grafika.Brzinomjer brzinomjer;

        public IgraPokrenuta(int sirina, int visina, bool snijeg)
        {
            mapa = new Mapa.Mapa(sirina, visina, snijeg);

            brzinomjer = new Grafika.Brzinomjer();

            kontrolerAuta = new Mapa.KontrolerAuta(mapa);
            kontrolerPjeshaka = new Mapa.KontrolerPjeshaka(mapa);

            pozicijaKamere = new Vector2(0, 0);
            zumiranje = 3f;
            mojBus = new Grafika.Vozila.MojBus(sirina/2,visina/2);

            //smjesti auta
            auta = new List<BoboTransporter.Grafika.Vozila.Auto>();
            pjeshaci = new List<Grafika.Vozila.Pjeshak>();
            Random rand = new Random();
            foreach (BoboTransporter.Mapa.Regija regija in mapa.Blok)
            {
                

                if (regija.Tip == Mapa.TipRegije.CESTAhorizontalna)
                {
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4 - 15, regija.PozYUMapi * 4 - 16, 3, rand.Next() % 8 + 2));
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4 - 14, regija.PozYUMapi * 4 - 13, 1, rand.Next() % 8 + 2));
                }
                else if (regija.Tip == Mapa.TipRegije.CESTAvertikalna)
                {
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4 - 16, regija.PozYUMapi * 4 - 15, 2, rand.Next() % 8 + 2));
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4 - 13, regija.PozYUMapi * 4 - 14, 0, rand.Next() % 8 + 2));
                }

                

                if (!Mapa.Regija.jeCestaIliCilj(regija.Tip))
                {
                    if (Mapa.Regija.jeCestaIliCilj(regija.TipGore))
                    {
                        if (rand.Next() % 3 == 0)
                        {
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 3, regija.PozYUMapi * 8 - 32, 3, rand.Next() % 8 + 1));
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 5, regija.PozYUMapi * 8 - 32 + 1, 1, rand.Next() % 8 + 1));
                        }

                    }
                    if (Mapa.Regija.jeCestaIliCilj(regija.TipDole))
                    {
                        if (rand.Next() % 3 == 0)
                        {
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 4, regija.PozYUMapi * 8 - 32 + 7, 1, rand.Next() % 8 + 1));
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 4, regija.PozYUMapi * 8 - 32 + 6, 3, rand.Next() % 8 + 1));
                        }
                    }
                    if (Mapa.Regija.jeCestaIliCilj(regija.TipLijevo))
                    {
                        if (rand.Next() % 3 == 0)
                        {
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32, regija.PozYUMapi * 8 - 32 + 3, 2, rand.Next() % 8 + 1));
                            pjeshaci.Add(new Grafika.Vozila.Pjeshak(regija.PozXUMapi * 8 - 32 + 1, regija.PozYUMapi * 8 - 32 + 5, 0, rand.Next() % 8 + 1));
                        }
                    }
                    if (Mapa.Regija.jeCestaIliCilj(regija.TipDesno))
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
            foreach (BoboTransporter.Grafika.Vozila.Auto auto in auta)
            {
                auto.LoadContent(theContentManager);
            }
            foreach (BoboTransporter.Grafika.Vozila.Pjeshak pjeshak in pjeshaci)
            {
                pjeshak.LoadContent(theContentManager);
            }
        }

        public void Update(GameTime gameTime)
        {
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
            if (sudarSaTrotoarom())
            {
                
                Console.WriteLine("TROTOAR");
            }
            foreach (Grafika.Vozila.Pjeshak pjeshak in pjeshaci)
            {
                if (sudarSaPjeshakom(pjeshak))
                {
                    Console.WriteLine("PJESHAK");
                }
            }
            foreach (Grafika.Vozila.Auto auto in auta)
            {
                if (sudarSaAutom(auto))
                {
                    Console.WriteLine("AUTO");
                }
            }
        }

        private float dajZoom(float brzinaBusa)
        {
            return Math.Max(3f/(float)Math.Exp(Math.Abs(brzinaBusa) * 5),1f);
        }

        private void UpdateKontrola(GameTime gameTime)
        {
            InputHandler.Update(gameTime);
            if (!InputHandler.Up && !InputHandler.Down)
            {
                mojBus.pustenGasMijenjajBrzinu(gameTime);
            }
            if (InputHandler.Up && !InputHandler.Down)
            {
                mojBus.ubrzavaj(gameTime);
            }
            if (InputHandler.Down && !InputHandler.Up)
            {
                mojBus.usporavaj(gameTime);
            }
            if (!InputHandler.Left && !InputHandler.Right)
            {
                mojBus.neSkreci(gameTime);
            }
            if (InputHandler.Left && !InputHandler.Right)
            {
                mojBus.skreciLijevo(gameTime);
            }
            if (InputHandler.Right && !InputHandler.Left)
            {
                mojBus.skreciDesno(gameTime);
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


            mapa.Draw(theSpriteBatch,pozicijaKamere, sredinaEkrana, zumiranje);
            mojBus.Draw(theSpriteBatch, pozicijaKamere, sredinaEkrana, zumiranje);
            foreach (BoboTransporter.Grafika.Vozila.Auto auto in auta)
            {
                auto.Draw(theSpriteBatch, pozicijaKamere, sredinaEkrana, zumiranje);
            }
            foreach (BoboTransporter.Grafika.Vozila.Pjeshak pjeshak in pjeshaci)
            {
                pjeshak.Draw(theSpriteBatch, pozicijaKamere, sredinaEkrana, zumiranje);
            }
        }

        public virtual void DrawHUD(GameTime gameTime, SpriteBatch theSpriteBatch, Vector2 sredinaEkrana)
        {

            brzinomjer.Draw(theSpriteBatch, sredinaEkrana, mojBus.Brzina);

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

        /*private bool provjeriSudarKutija(Vector2 poz1, float rot1, float sir1, float vis1, Vector2 poz2, float rot2, float sir2, float vis2)
        {
            /* u listi:
             * 1. - koef uz X
             * 2. - koef uz Y
             * 3. - desna strana jednakosti
             * 4. - x1
             * 5. - y1
             * 6. - x2
             * 7. - y2
             *
            float a,b,c1,c2;
            List<float> trenutna;
            List<List<float>> linije1 = new List<List<float>>();
            trenutna = new List<float>();
            trenutna.Add(a = (float)Math.Sin(rot1));
            trenutna.Add(b = (float)-Math.Cos(rot1));
            c1 = (float)(poz1.X + Math.Sin(rot1) * vis1 / 2);
            c2 = (float)(poz1.Y - Math.Cos(rot1) * vis1 / 2);
            trenutna.Add(c1 * a + c2 * b);
            trenutna.Add(c1 - (float)Math.Cos(rot1) * sir1 / 2);
            trenutna.Add(c2 - (float)Math.Sin(rot1) * sir1 / 2);
            trenutna.Add(c1 + (float)Math.Cos(rot1) * sir1 / 2);
            trenutna.Add(c2 + (float)Math.Sin(rot1) * sir1 / 2);
            trenutna.Add(1);
            linije1.Add(trenutna);

            trenutna = new List<float>();
            trenutna.Add(a = (float)Math.Sin(rot1));
            trenutna.Add(b = (float)-Math.Cos(rot1));
            c1 = (float)(poz1.X - Math.Sin(rot1) * vis1 / 2);
            c2 = (float)(poz1.Y + Math.Cos(rot1) * vis1 / 2);
            trenutna.Add(c1 * a + c2 * b);
            trenutna.Add(c1 - (float)Math.Cos(rot1) * sir1 / 2);
            trenutna.Add(c2 - (float)Math.Sin(rot1) * sir1 / 2);
            trenutna.Add(c1 + (float)Math.Cos(rot1) * sir1 / 2);
            trenutna.Add(c2 + (float)Math.Sin(rot1) * sir1 / 2);
            trenutna.Add(2);
            linije1.Add(trenutna);

            trenutna = new List<float>();
            trenutna.Add(a = (float)Math.Cos(rot1));
            trenutna.Add(b = (float)Math.Sin(rot1));
            c1 = (float)(poz1.X + Math.Cos(rot1) * sir1 / 2);
            c2 = (float)(poz1.Y + Math.Sin(rot1) * sir1 / 2);
            trenutna.Add(c1 * a + c2 * b);
            trenutna.Add(c1 - (float)Math.Sin(rot1) * vis1 / 2);
            trenutna.Add(c2 + (float)Math.Cos(rot1) * vis1 / 2);
            trenutna.Add(c1 + (float)Math.Sin(rot1) * vis1 / 2);
            trenutna.Add(c2 - (float)Math.Cos(rot1) * vis1 / 2);
            trenutna.Add(3);
            linije1.Add(trenutna);

            trenutna = new List<float>();
            trenutna.Add(a = (float)Math.Cos(rot1));
            trenutna.Add(b = (float)Math.Sin(rot1));
            c1 = (float)(poz1.X - Math.Cos(rot1) * sir1 / 2);
            c2 = (float)(poz1.Y - Math.Sin(rot1) * sir1 / 2);
            trenutna.Add(c1 * a + c2 * b);
            trenutna.Add(c1 - (float)Math.Sin(rot1) * vis1 / 2);
            trenutna.Add(c2 + (float)Math.Cos(rot1) * vis1 / 2);
            trenutna.Add(c1 + (float)Math.Sin(rot1) * vis1 / 2);
            trenutna.Add(c2 - (float)Math.Cos(rot1) * vis1 / 2);
            trenutna.Add(4);
            linije1.Add(trenutna);


            List<List<float>> linije2 = new List<List<float>>();
            trenutna = new List<float>();
            trenutna.Add(a = (float)Math.Sin(rot2));
            trenutna.Add(b = (float)-Math.Cos(rot2));
            c1 = (float)(poz2.X + Math.Sin(rot2) * vis2 / 2);
            c2 = (float)(poz2.Y - Math.Cos(rot2) * vis2 / 2);
            trenutna.Add(c1 * a + c2 * b);
            trenutna.Add(c1 - (float)Math.Cos(rot2) * sir2 / 2);
            trenutna.Add(c2 - (float)Math.Sin(rot2) * sir2 / 2);
            trenutna.Add(c1 + (float)Math.Cos(rot2) * sir2 / 2);
            trenutna.Add(c2 + (float)Math.Sin(rot2) * sir2 / 2);
            trenutna.Add(1);
            linije2.Add(trenutna);

            trenutna = new List<float>();
            trenutna.Add(a = (float)Math.Sin(rot2));
            trenutna.Add(b = (float)-Math.Cos(rot2));
            c1 = (float)(poz2.X - Math.Sin(rot2) * vis2 / 2);
            c2 = (float)(poz2.Y + Math.Cos(rot2) * vis2 / 2);
            trenutna.Add(c1 * a + c2 * b);
            trenutna.Add(c1 - (float)Math.Cos(rot2) * sir2 / 2);
            trenutna.Add(c2 - (float)Math.Sin(rot2) * sir2 / 2);
            trenutna.Add(c1 + (float)Math.Cos(rot2) * sir2 / 2);
            trenutna.Add(c2 + (float)Math.Sin(rot2) * sir2 / 2);
            trenutna.Add(2);
            linije2.Add(trenutna);

            trenutna = new List<float>();
            trenutna.Add(a = (float)Math.Cos(rot2));
            trenutna.Add(b = (float)Math.Sin(rot2));
            c1 = (float)(poz2.X + Math.Cos(rot2) * sir2 / 2);
            c2 = (float)(poz2.Y + Math.Sin(rot2) * sir2 / 2);
            trenutna.Add(c1 * a + c2 * b);
            trenutna.Add(c1 - (float)Math.Sin(rot2) * vis2 / 2);
            trenutna.Add(c2 + (float)Math.Cos(rot2) * vis2 / 2);
            trenutna.Add(c1 + (float)Math.Sin(rot2) * vis2 / 2);
            trenutna.Add(c2 - (float)Math.Cos(rot2) * vis2 / 2);
            trenutna.Add(3);
            linije2.Add(trenutna);

            trenutna = new List<float>();
            trenutna.Add(a = (float)Math.Cos(rot2));
            trenutna.Add(b = (float)Math.Sin(rot2));
            c1 = (float)(poz2.X - Math.Cos(rot2) * sir2 / 2);
            c2 = (float)(poz2.Y - Math.Sin(rot2) * sir2 / 2);
            trenutna.Add(c1 * a + c2 * b);
            trenutna.Add(c1 - (float)Math.Sin(rot2) * vis2 / 2);
            trenutna.Add(c2 + (float)Math.Cos(rot2) * vis2 / 2);
            trenutna.Add(c1 + (float)Math.Sin(rot2) * vis2 / 2);
            trenutna.Add(c2 - (float)Math.Cos(rot2) * vis2 / 2);
            trenutna.Add(4);
            linije2.Add(trenutna);

            foreach (List<float> linija1 in linije1)
            {
                foreach (List<float> linija2 in linije2)
                {
                    if (sePresjecaju(linija1,linija2))
                    {
                        Console.WriteLine("{0} {1}",linija1[7], linija2[7]);
                        return true;
                    }
                }
            }

            return false;



            return false;
        }

        private static bool sePresjecaju(List<float> linija1, List<float> linija2)
        {
            /* u listi:
             * 1. - koef uz X
             * 2. - koef uz Y
             * 3. - desna strana jednakosti
             * 4. - x1
             * 5. - y1
             * 6. - x2
             * 7. - y2
             *
            
            float dx, dy, dd;
            dd = linija1[0] * linija2[1] - linija1[1] * linija2[0];
            if (dd < 0.0001f) return false;
            dx = linija1[2] * linija2[1] - linija1[1] * linija2[2];
            dy = linija1[0] * linija2[2] - linija1[2] * linija2[0];
            dx /= dd;
            dy /= dd;
            if (
                suprotne(linija1[3], dx, linija1[5]) &&
                suprotne(linija2[3], dx, linija2[5]) &&
                suprotne(linija1[4], dy, linija1[6]) &&
                suprotne(linija2[4], dy, linija2[6])
                )
                return true;
            
            return false;
        }*/

        private static bool suprotne(float t1, float ts, float t2)
        {
            if ((t1 - ts < 0.0001f) && (ts - t2 < 0.0001f)) return true;
            if ((t1 - ts < 0.0001f) && (ts - t2 < 0.0001f)) return true;
            return false;
        }

        private bool tackaNaTrotoaru(float posX, float posY)
        {
            return (!Mapa.Regija.jeProhodnaCestaIliCilj(mapa.Blok[(int)(posX) / 150, (int)(posY) / 150].Tip));
        }

    }
}
