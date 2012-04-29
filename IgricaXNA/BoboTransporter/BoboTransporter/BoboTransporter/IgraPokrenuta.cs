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
        BoboTransporter.Grafika.Vozila.MojBus mojBus;
        float zumiranje;
        Vector2 pozicijaKamere;

        public IgraPokrenuta(int sirina, int visina, bool snijeg)
        {
            mapa = new Mapa.Mapa(sirina, visina, snijeg);
            pozicijaKamere = new Vector2(0, 0);
            zumiranje = 1f;
            mojBus = new Grafika.Vozila.MojBus(sirina/2,visina/2);
        }

        public virtual void LoadContent(ContentManager theContentManager)
        {
            mapa.LoadContent(theContentManager);
            mojBus.LoadContent(theContentManager);
        }

        public void Update(GameTime gameTime)
        {
            UpdateKontrola(gameTime);
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
        }

    }
}
