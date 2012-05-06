using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using BoboTransporter.Grafika;

namespace BoboTransporter.MeniDugmad
{

    class Poruka : MenuItem
    {
        protected Slicica osnovno_stanje;
        protected string tekstura;
        float velicina;

        public float Velicina
        {
            get { return velicina; }
            set { velicina = value; }
        }
        float povecanje;

        public float Povecanje
        {
            get { return povecanje; }
            set { povecanje = value; }
        }

        public Poruka()
        {
            osnovno_stanje = new Slicica();
            osnovno_stanje.Okvir = new Rectangle(0, 0, 600, 100);
            osnovno_stanje.Sredina = new Vector2(300, 50);
            velicina = 1f;
            povecanje = 1f;
            osnovno_stanje.Velicina = velicina;
            Pozicija = new Vector2(0, 0);
            osnovno_stanje.VertikalnaPozicija = 0.5f;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            osnovno_stanje.LoadContent(theContentManager, String.Format("Poruka\\{0}", tekstura));
        }

        public override void Update(GameTime gameTime)
        {
            osnovno_stanje.Velicina = velicina * povecanje;
            doButtonWork(gameTime);
        }

        public override void Draw(SpriteBatch theSpriteBatch, Vector2 cameraPosition, Vector2 sredinaEkrana, float zumiranje)
        {
            osnovno_stanje.Draw(theSpriteBatch, cameraPosition - Pozicija, sredinaEkrana, zumiranje);
        }

        public virtual void doButtonWork(GameTime gameTime)
        {

        }

    }


}
