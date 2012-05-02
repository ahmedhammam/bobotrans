using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika
{

    class Brzinomjer
    {
        BrzinomjerDijelovi.Strelica strelica;
        BrzinomjerDijelovi.Pozadina pozadina;
        float velicina;

        public Brzinomjer()
        {
            velicina = 0.7f;
            strelica = new BrzinomjerDijelovi.Strelica();
            pozadina = new BrzinomjerDijelovi.Pozadina();
            strelica.Velicina *= velicina;
            pozadina.Boja = Color.FromNonPremultiplied(255, 255, 255, 193);
            strelica.Boja = Color.FromNonPremultiplied(255, 255, 255, 193);
            pozadina.Velicina *= velicina;
        }

        public void LoadContent(ContentManager theContentManager)
        {
            pozadina.LoadContent(theContentManager);
            strelica.LoadContent(theContentManager);
        }

        public void Draw(SpriteBatch theSpriteBatch, Vector2 sredinaEkrana, float brzina)
        {
            float ugao;
            ugao = -((float)Math.PI * 14f / 18f) + (float)(Math.PI * Math.Abs(brzina) * 2);
            strelica.Rotacija = ugao;
            pozadina.Draw(theSpriteBatch, new Vector2(-sredinaEkrana.X + 250 * velicina, -sredinaEkrana.Y + 250 * velicina), sredinaEkrana, 1f);
            strelica.Draw(theSpriteBatch, new Vector2(-sredinaEkrana.X + 250 * velicina, -sredinaEkrana.Y + 250 * velicina), sredinaEkrana, 1f);
        }


    }
}
