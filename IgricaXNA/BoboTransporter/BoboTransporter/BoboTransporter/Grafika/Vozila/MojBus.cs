using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika.Vozila
{
    class MojBus:Slicica
    {
        static private string teksturaIme = "autobusTekstura";
        float brzina;
        float maxBrzina, minBrzina;
        int tockoviPozicija;
        public MojBus(int pozX, int pozY)
        {
            Pozicija = new Vector2(300f * pozX + 825f, 300f * pozY + 825f);
            Rotacija = 0f;
            VertikalnaPozicija = 0.3f;
            Velicina = .2f;
            Okvir = new Rectangle(0, 0, 300, 300);
            Sredina = new Vector2(150, 150);
            brzina = 0;
            tockoviPozicija = 0;
            maxBrzina = 0.5f;
            minBrzina = -0.08f;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            LoadContent(theContentManager, teksturaIme);
        }

        public Vector2 smjestiKameru()
        {
            return Pozicija;
        }

        public void Update(GameTime gameTime)
        {
            vozi(gameTime);
        }

        public void ubrzavaj(GameTime gameTime)
        {
            brzina += ubrzanje() * gameTime.ElapsedGameTime.Milliseconds;
        }

        public void usporavaj(GameTime gameTime)
        {
            brzina -= usporenje() * gameTime.ElapsedGameTime.Milliseconds;
        }

        public void pustenGasMijenjajBrzinu(GameTime gameTime)
        {
            if (brzina > 0)
            {
                brzina -= ubrzanje() * 0.2f * gameTime.ElapsedGameTime.Milliseconds;
            }
            if (brzina < 0)
            {
                brzina += ubrzanje() * 0.2f * gameTime.ElapsedGameTime.Milliseconds;
            }
        }

        public void skreciDesno(GameTime gameTime)
        {
            tockoviPozicija = 1;
        }

        public void skreciLijevo(GameTime gameTime)
        {
            tockoviPozicija = -1;
        }

        public void neSkreci(GameTime gameTime)
        {
            tockoviPozicija = 0;
        }

        private float ubrzanje()
        {
            if (brzina>=0f && brzina < maxBrzina)
            {
                return(0.000064f * (float)Math.Exp(-brzina * 4f));
            }
            else if (brzina < 0f)
            {
                return (0.00012f);
            }
            else
            {
                return (-0.000004f);
            }
        }

        private float usporenje()
        {
            if (brzina <= 0f && brzina > minBrzina)
            {
                return (0.000016f * (float)Math.Exp(brzina * 4f));
            }
            else if (brzina > 0f)
            {
                return (0.00012f);
            }
            else
            {
                return (-0.000004f);
            }
        }

        public void vozi(GameTime gameTime)
        {
            Pozicija -= new Vector2(brzina * gameTime.ElapsedGameTime.Milliseconds * (float)Math.Sin(-Rotacija), brzina * gameTime.ElapsedGameTime.Milliseconds * (float)Math.Cos(-Rotacija));
            if (tockoviPozicija == 1)
            {
                Rotacija += rotiranje() * brzina * gameTime.ElapsedGameTime.Milliseconds;
            }
            else if (tockoviPozicija == -1)
            {
                Rotacija -= rotiranje() * brzina * gameTime.ElapsedGameTime.Milliseconds;
            }
        }

        public float rotiranje()
        {
            return ((float)Math.PI * 0.001f / (Math.Abs(brzina)+0.025f));
        }

    }
}
