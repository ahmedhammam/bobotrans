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
    class GlavniMeni
    {
        Play play;
        Options options;
        Help help;
        Quit quit;
        MenuItem izabranoDugme;
        Vector2 pozicija;
        int vrijemePritiska;

        public GlavniMeni()
        {
            vrijemePritiska = 0;
            play = new Play();
            options = new Options();
            help = new Help();
            quit = new Quit();
            play.Pozicija = new Vector2(-200, -100);
            options.Pozicija = new Vector2(200, -100);
            help.Pozicija = new Vector2(-200, 100);
            quit.Pozicija = new Vector2(200, 100);
            izabranoDugme = play;
            pozicija = new Vector2(0, -1000);
        }

        public void LoadContent(ContentManager theContentManager)
        {
            play.LoadContent(theContentManager);
            options.LoadContent(theContentManager);
            help.LoadContent(theContentManager);
            quit.LoadContent(theContentManager);
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

            if (InputHandler.DesnoMeni && izabranoDugme == play) izabranoDugme = options;
            if (InputHandler.DesnoMeni && izabranoDugme == help) izabranoDugme = quit;
            if (InputHandler.LijevoMeni && izabranoDugme == options) izabranoDugme = play;
            if (InputHandler.LijevoMeni && izabranoDugme == quit) izabranoDugme = help;
            if (InputHandler.GoreMeni && izabranoDugme == help) izabranoDugme = play;
            if (InputHandler.GoreMeni && izabranoDugme == quit) izabranoDugme = options;
            if (InputHandler.DoleMeni && izabranoDugme == play) izabranoDugme = help;
            if (InputHandler.DoleMeni && izabranoDugme == options) izabranoDugme = quit;
        }

        public void Draw(SpriteBatch theSpriteBatch, Vector2 sredinaEkrana, float zumiranje)
        {
            if (vrijemePritiska == 0 && Opcije.gamePointer.loadaj)
            {
                vrijemePritiska = 500;
                pozicija = new Vector2(0, -1000);
            }
            play.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            options.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            help.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            quit.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            theSpriteBatch.Draw(Opcije.pozadinaOsnovno, new Rectangle(0, 0, (int)sredinaEkrana.X * 2, (int)sredinaEkrana.Y * 2), Color.White);
        }

    }
}
