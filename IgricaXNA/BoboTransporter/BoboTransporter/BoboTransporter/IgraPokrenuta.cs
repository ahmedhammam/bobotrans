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
        BoboTransporter.Grafika.Vozila.MojBus mojBus;
        List<BoboTransporter.Grafika.Vozila.Auto> auta;
        float zumiranje;
        Vector2 pozicijaKamere;

        public IgraPokrenuta(int sirina, int visina, bool snijeg)
        {
            mapa = new Mapa.Mapa(sirina, visina, snijeg);

            kontrolerAuta = new Mapa.KontrolerAuta(mapa);

            pozicijaKamere = new Vector2(0, 0);
            zumiranje = 1f;
            mojBus = new Grafika.Vozila.MojBus(sirina/2,visina/2);

            //smjesti auta
            auta = new List<BoboTransporter.Grafika.Vozila.Auto>();

            foreach (BoboTransporter.Mapa.Regija regija in mapa.Blok)
            {
                if (regija.Tip == Mapa.TipRegije.CESTAhorizontalna)
                {
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4-16, regija.PozYUMapi * 4-16, 3));
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4-13, regija.PozYUMapi * 4-13, 1));
                }
                else if (regija.Tip == Mapa.TipRegije.CESTAvertikalna)
                {
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4-16, regija.PozYUMapi * 4-16, 2));
                    auta.Add(new Grafika.Vozila.Auto(regija.PozXUMapi * 4-13, regija.PozYUMapi * 4-13, 0));
                }
            }

        }

        public virtual void LoadContent(ContentManager theContentManager)
        {
            mapa.LoadContent(theContentManager);
            mojBus.LoadContent(theContentManager);
            foreach (BoboTransporter.Grafika.Vozila.Auto auto in auta)
            {
                auto.LoadContent(theContentManager);
            }
        }

        public void Update(GameTime gameTime)
        {
            UpdateKontrola(gameTime);
            foreach (BoboTransporter.Grafika.Vozila.Auto auto in auta)
            {
                auto.postaviKretanje(kontrolerAuta.Polje[(int)auto.PozicijaCelije.X, (int)auto.PozicijaCelije.Y]);
                auto.Update(gameTime);
            }
            mojBus.Update(gameTime);
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

            //postavi kameru na tacno mjesto
            pozicijaKamere = mojBus.smjestiKameru();


            mapa.Draw(theSpriteBatch,pozicijaKamere, sredinaEkrana, zumiranje);
            mojBus.Draw(theSpriteBatch, pozicijaKamere, sredinaEkrana, zumiranje);
            foreach (BoboTransporter.Grafika.Vozila.Auto auto in auta)
            {
                auto.Draw(theSpriteBatch, pozicijaKamere, sredinaEkrana, zumiranje);
            }
        }

    }
}
