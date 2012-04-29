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
        float zumiranje;
        Vector2 pozicijaKamere;

        public IgraPokrenuta(int sirina, int visina, bool snijeg)
        {
            mapa = new Mapa.Mapa(sirina, visina, snijeg);
            pozicijaKamere = new Vector2(0, 0);
            zumiranje = 0.5f;
        }

        public virtual void LoadContent(ContentManager theContentManager)
        {
            mapa.LoadContent(theContentManager);
        }

        public void Update(GameTime gameTime)
        {
            InputHandler.Update(gameTime);
            if (InputHandler.Up)
            {
                pozicijaKamere.Y -= gameTime.ElapsedGameTime.Milliseconds;
            }
            if (InputHandler.Down)
            {
                pozicijaKamere.Y += gameTime.ElapsedGameTime.Milliseconds;
            }
            if (InputHandler.Left)
            {
                pozicijaKamere.X -= gameTime.ElapsedGameTime.Milliseconds;
            }
            if (InputHandler.Right)
            {
                pozicijaKamere.X += gameTime.ElapsedGameTime.Milliseconds;
            }
        }

        public virtual void Draw(SpriteBatch theSpriteBatch, Vector2 sredinaEkrana)
        {
            mapa.Draw(theSpriteBatch,pozicijaKamere, sredinaEkrana, zumiranje);
        }

    }
}
