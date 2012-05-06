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
using BoboTransporter.MeniDugmad.Poruke;

namespace BoboTransporter.Meniji
{
    class LoseMeni
    {
        Play quitYes;
        QuitToMain quitNo;
        MenuItem izabranoDugme;
        Vector2 pozicija;
        Kraj naslov;
        int vrijemePritiska;

        public LoseMeni()
        {
            vrijemePritiska = 0;
            quitYes = new Play();
            quitNo = new QuitToMain();
            naslov = new Kraj();
            quitYes.Pozicija = new Vector2(-200, 0);
            quitNo.Pozicija = new Vector2(200, -0);
            naslov.Pozicija = new Vector2(0, -200);
            izabranoDugme = quitYes;
            pozicija = new Vector2(0, -1000);
        }

        public void LoadContent(ContentManager theContentManager)
        {
            quitYes.LoadContent(theContentManager);
            quitNo.LoadContent(theContentManager);
            naslov.LoadContent(theContentManager);
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
                izabranoDugme = quitYes;
            }
            quitYes.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            quitNo.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            naslov.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            theSpriteBatch.Draw(Opcije.pozadina, new Rectangle(0, 0, (int)sredinaEkrana.X * 2, (int)sredinaEkrana.Y * 2), Color.White);
        }

    }
}
