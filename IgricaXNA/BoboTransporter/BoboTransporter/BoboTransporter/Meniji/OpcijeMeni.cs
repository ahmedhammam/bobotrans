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
    class OpcijeMeni
    {
        MapaUpaljenost mapaUpaljenost;
        BrzinomjerUpaljenost brzinomjerUpaljenost;
        VrijemeUpaljenost vrijemeUpaljenost;
        QuitToMain quitToMain;
        MenuItem izabranoDugme;
        Vector2 pozicija;
        int vrijemePritiska;

        public OpcijeMeni()
        {
            vrijemePritiska = 0;
            mapaUpaljenost = new MapaUpaljenost();
            brzinomjerUpaljenost = new BrzinomjerUpaljenost();
            vrijemeUpaljenost = new VrijemeUpaljenost();
            quitToMain = new QuitToMain();
            mapaUpaljenost.Pozicija = new Vector2(-200, 0);
            brzinomjerUpaljenost.Pozicija = new Vector2(0, -200);
            vrijemeUpaljenost.Pozicija = new Vector2(200, 0);
            quitToMain.Pozicija = new Vector2(0, 200);
            izabranoDugme = brzinomjerUpaljenost;
            pozicija = new Vector2(0, -1000);
        }

        public void LoadContent(ContentManager theContentManager)
        {
            mapaUpaljenost.LoadContent(theContentManager);
            brzinomjerUpaljenost.LoadContent(theContentManager);
            vrijemeUpaljenost.LoadContent(theContentManager);
            quitToMain.LoadContent(theContentManager);
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

            if (InputHandler.DesnoMeni) izabranoDugme = vrijemeUpaljenost;
            if (InputHandler.LijevoMeni) izabranoDugme = mapaUpaljenost;
            if (InputHandler.GoreMeni) izabranoDugme = brzinomjerUpaljenost;
            if (InputHandler.DoleMeni) izabranoDugme = quitToMain;
        }

        public void Draw(SpriteBatch theSpriteBatch, Vector2 sredinaEkrana, float zumiranje)
        {
            if (vrijemePritiska == 0 && Opcije.gamePointer.loadaj)
            {
                vrijemePritiska = 500;
                pozicija = new Vector2(0, -1000);
                izabranoDugme = quitToMain;
            }
            mapaUpaljenost.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            brzinomjerUpaljenost.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            vrijemeUpaljenost.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            quitToMain.Draw(theSpriteBatch, pozicija, sredinaEkrana, zumiranje);
            theSpriteBatch.Draw(Opcije.pozadinaOsnovno, new Rectangle(0, 0, (int)sredinaEkrana.X * 2, (int)sredinaEkrana.Y * 2), Color.White);
        }

    }
}
