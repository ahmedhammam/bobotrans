using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using BoboTransporter.EngineTools;
using BoboTransporter.MeniDugmad;
using BoboTransporter.MeniDugmad.Dugmadi;

namespace BoboTransporter.Meniji
{
    class IzlazMeni
    {
        QuitYes quitYes;
        QuitNo quitNo;
        MenuItem izabranoDugme;
        Vector2 pozicija;
        int vrijemePritiska;

        public IzlazMeni()
        {
            vrijemePritiska = 0;
            quitYes = new QuitYes();
            quitNo = new QuitNo();
            quitYes.Pozicija = new Vector2(-200, 0);
            quitNo.Pozicija = new Vector2(200, -0);
            izabranoDugme = quitNo;
            pozicija = new Vector2(0, -1000);
        }

        public void LoadContent(ContentManager theContentManager)
        {
            quitYes.LoadContent(theContentManager);
            quitNo.LoadContent(theContentManager);
        }

        public void Update(GameTime gameTime)
        {
            if (vrijemePritiska == 0 && Opcije.gamePointer.loadaj)
            {
                vrijemePritiska = 500;
                pozicija = new Vector2(0, -1000);
            }
            if (!Opcije.gamePointer.loadaj)
            {
                izabranoDugme.Update(gameTime);
            }
            else
            {
                vrijemePritiska -= gameTime.ElapsedGameTime.Milliseconds;
                if (vrijemePritiska <= 0)
                {
                    Opcije.gamePointer.loadaj = false;
                    vrijemePritiska=0;
                }
            }
            if (pozicija.X > izabranoDugme.Pozicija.X) pozicija.X -= (float)gameTime.ElapsedGameTime.Milliseconds * 2.5f;
            if (pozicija.X < izabranoDugme.Pozicija.X) pozicija.X += (float)gameTime.ElapsedGameTime.Milliseconds * 2.5f;
            if (pozicija.Y > izabranoDugme.Pozicija.Y) pozicija.Y -= (float)gameTime.ElapsedGameTime.Milliseconds * 2.5f;
            if (pozicija.Y < izabranoDugme.Pozicija.Y) pozicija.Y += (float)gameTime.ElapsedGameTime.Milliseconds * 2.5f;

            if (InputHandler.DesnoMeni && izabranoDugme == quitYes) izabranoDugme = quitNo;
            if (InputHandler.LijevoMeni && izabranoDugme == quitNo) izabranoDugme = quitYes;
        }

        public void Draw(SpriteBatch theSpriteBatch, Vector2 sredinaEkrana, float zumiranje)
        {
            if (vrijemePritiska == 0 && Opcije.gamePointer.loadaj)
            {
                vrijemePritiska = 500;
                pozicija = new Vector2(0, -1000);
            }
            quitYes.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            quitNo.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            theSpriteBatch.Draw(Opcije.pozadinaOsnovno, new Rectangle(0, 0, (int)sredinaEkrana.X * 2, (int)sredinaEkrana.Y * 2), Color.White);
        }

    }
}
