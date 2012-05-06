using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika
{
    class VrijemeBrojac
    {
        int vrijemeProteklo; //u milisekundama
        Slicica tacke;
        Slicica brojevi;

        public VrijemeBrojac()
        {
            vrijemeProteklo = 0;
            tacke = new Slicica();
            brojevi = new Slicica();
            tacke.Okvir = new Rectangle(0, 0, 400, 50);
            tacke.Sredina = new Vector2(200, 0);
            brojevi.Sredina = new Vector2(0, 0);
            brojevi.Okvir = new Rectangle(0, 0, 50, 50);
        }

        public void resetujBrojac()
        {
            vrijemeProteklo = 0;
        }

        public void Update(GameTime gameTime)
        {
            vrijemeProteklo += gameTime.ElapsedGameTime.Milliseconds;
        }

        public void LoadContent(ContentManager theContentManager)
        {
            tacke.LoadContent(theContentManager,"tackeTekstura");
            brojevi.LoadContent(theContentManager, "brojeviTekstura");
        }

        public void Draw(SpriteBatch theSpriteBatch, Vector2 sredinaEkrana)
        {
            //ispis tacki
            tacke.Draw(theSpriteBatch, new Vector2(0, sredinaEkrana.Y), sredinaEkrana, 1f);

            int vrijemeSada = vrijemeProteklo;
            vrijemeSada /= 1000;

            postaviBroj(vrijemeSada % 10);
            vrijemeSada /= 10;
            brojevi.Draw(theSpriteBatch, new Vector2(-150, sredinaEkrana.Y), sredinaEkrana, 1f);
            postaviBroj(vrijemeSada % 6);
            vrijemeSada /= 6;
            brojevi.Draw(theSpriteBatch, new Vector2(-100, sredinaEkrana.Y), sredinaEkrana, 1f);
            postaviBroj(vrijemeSada % 10);
            vrijemeSada /= 10;
            brojevi.Draw(theSpriteBatch, new Vector2(0, sredinaEkrana.Y), sredinaEkrana, 1f);
            postaviBroj(vrijemeSada % 6);
            vrijemeSada /= 6;
            brojevi.Draw(theSpriteBatch, new Vector2(50, sredinaEkrana.Y), sredinaEkrana, 1f);
            postaviBroj(vrijemeSada % 10);
            vrijemeSada /= 10;
            brojevi.Draw(theSpriteBatch, new Vector2(150, sredinaEkrana.Y), sredinaEkrana, 1f);
            postaviBroj(vrijemeSada % 10);
            brojevi.Draw(theSpriteBatch, new Vector2(200, sredinaEkrana.Y), sredinaEkrana, 1f);

        }

        private void postaviBroj(int broj)
        {
            brojevi.Okvir = new Rectangle(broj*50, 0, 50, 50);
        }

    }
}
