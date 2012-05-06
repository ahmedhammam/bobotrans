using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika
{
    class Minimapa
    {
        Slicica a;
        Slicica b;
        public Minimapa()
        {
            a = new Slicica();
            a.Sredina = new Vector2(5, 5);
            a.Okvir = new Rectangle(0, 0, 10, 10);
            a.VertikalnaPozicija = 0.1f;
            b = new Slicica();
            b.Sredina = new Vector2(5, 5);
            b.Okvir = new Rectangle(0, 0, 10, 10);
            b.VertikalnaPozicija = 0.2f;
        }

        public void LoadContent(ContentManager theContentManager)
        {
            //pozadina.LoadContent(theContentManager);
            a.LoadContent(theContentManager, "mapaCelijaTekstura");
            b.LoadContent(theContentManager, "mapaAutobusTekstura");
        }

        public void Draw(SpriteBatch theSpriteBatch, Vector2 sredinaEkrana, Mapa.Mapa mapa, Vector2 busPozicija)
        {
            int sirina = mapa.Sirina;
            int visina = mapa.Visina;
            int dimenzijaPolja;
            dimenzijaPolja = 300 / Math.Max(sirina, visina);
            a.Velicina = 0.025f * dimenzijaPolja;
            b.Pozicija = new Vector2(dimenzijaPolja * (busPozicija.X - 75f) / 150f, dimenzijaPolja * (busPozicija.Y - 75f) / 150f);
            for (int i=0;i<sirina;i++)
                for (int j = 0; j < visina; j++)
                {
                    if (Mapa.Regija.jeCestaIliCilj(mapa.Blok[i, j].Tip))
                    {
                        a.Velicina = 0.1f * dimenzijaPolja;
                        a.Pozicija = new Vector2(dimenzijaPolja * i, dimenzijaPolja * j);
                        a.Boja = Color.FromNonPremultiplied(255, 0, 0, 127);
                        if (Mapa.Regija.jeProhodnaCesta(mapa.Blok[i, j].Tip)) a.Boja = Color.FromNonPremultiplied(255, 255, 255, 191);
                        if (mapa.Blok[i, j].Tip == Mapa.TipRegije.CILJ) a.Boja = Color.FromNonPremultiplied(0, 255, 0, 191);
                        a.Draw(theSpriteBatch, new Vector2(sredinaEkrana.X, -sredinaEkrana.Y + dimenzijaPolja * visina), sredinaEkrana, 1f);
                    }
                }
            b.Draw(theSpriteBatch, new Vector2(sredinaEkrana.X, -sredinaEkrana.Y + dimenzijaPolja * visina), sredinaEkrana, 1f);
        }

    }
}
