using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.Grafika
{
    class Slicica
    {
        private Vector2 pozicija;
        private float rotacija;
        private float velicina;
        private Texture2D tekstura;

        public Texture2D TeksturaSl
        {
            get { return tekstura; }
            set { tekstura = value; }
        }
        private Rectangle okvir;
        private Vector2 sredina;
        private Color boja;
        private float vertikalnaPozicija;

        #region Enkapsulacije

        public Vector2 Pozicija
        {
            get { return pozicija; }
            set { pozicija = value; }
        }


        public float Rotacija
        {
            get { return rotacija; }
            set { rotacija = value; }
        }


        public float Velicina
        {
            get { return velicina; }
            set { velicina = value; }
        }


        public Texture2D Tekstura
        {
            get { return tekstura; }
            set { tekstura = value; }
        }


        public Rectangle Okvir
        {
            get { return okvir; }
            set { okvir = value; }
        }


        public Vector2 Sredina
        {
            get { return sredina; }
            set { sredina = value; }
        }


        public Color Boja
        {
            get { return boja; }
            set { boja = value; }
        }

        public float VertikalnaPozicija
        {
            get { return vertikalnaPozicija; }
            set { vertikalnaPozicija = value; }
        } 
        #endregion

        public Slicica()
        {
            pozicija = new Vector2(0, 0);
            rotacija = 0f;
            velicina = 1f;
            okvir = new Rectangle(0, 0, 400, 400);
            sredina = new Vector2(200, 200);
            boja = Color.White;
            vertikalnaPozicija = 0;
        }

        public virtual void LoadContent(ContentManager theContentManager, string theAssetName)
        {
            tekstura = theContentManager.Load<Texture2D>(theAssetName);
        }

        public virtual void LoadContent(ContentManager theContentManager)
        {
            tekstura = theContentManager.Load<Texture2D>("empty");
        }

        public virtual void Draw(SpriteBatch theSpriteBatch, Vector2 cameraPosition, Vector2 sredinaEkrana, float zumiranje)
        {
            theSpriteBatch.Draw(tekstura,(pozicija-cameraPosition)*zumiranje+sredinaEkrana,okvir,boja,rotacija,sredina,velicina*zumiranje,SpriteEffects.None,vertikalnaPozicija);
        }

        public virtual void DrawInRegion(SpriteBatch theSpriteBatch, Vector2 cameraPosition, Vector2 sredinaEkrana, float zumiranje, Vector2 regionPosition)
        {
            theSpriteBatch.Draw(tekstura, (pozicija + regionPosition - cameraPosition) * zumiranje + sredinaEkrana, okvir, boja, rotacija, sredina, velicina * zumiranje, SpriteEffects.None, vertikalnaPozicija);
        }

    }
}
