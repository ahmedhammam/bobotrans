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

    class VisestrukoDugme:MenuItem
    {
        Slicica stanje1;
        Slicica stanje2;
        Slicica stanje3;
        protected string tekstura1;
        protected string tekstura2;
        protected string tekstura3;
        float velicina;
        protected int stanje;

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

        public VisestrukoDugme()
        {
            stanje =0;
            stanje1 = new Slicica();
            stanje1.Okvir = new Rectangle(0, 0, 700, 700);
            stanje1.Sredina = new Vector2(350, 350);
            stanje2 = new Slicica();
            stanje2.Okvir = new Rectangle(0, 0, 700, 700);
            stanje2.Sredina = new Vector2(350, 350);
            stanje3 = new Slicica();
            stanje3.Okvir = new Rectangle(0, 0, 700, 700);
            stanje3.Sredina = new Vector2(350, 350);
            velicina = 0.3f;
            povecanje = 1f;
            stanje1.Velicina = velicina;
            stanje2.Velicina = velicina;
            stanje3.Velicina = velicina;
            Pozicija = new Vector2(0, 0);
            stanje1.VertikalnaPozicija = 0.5f;
            stanje2.VertikalnaPozicija = 0.5f;
            stanje3.VertikalnaPozicija = 0.5f;
        }

        public override void LoadContent(ContentManager theContentManager)
        {
            stanje1.LoadContent(theContentManager, String.Format("Dugme\\{0}",tekstura1));
            stanje2.LoadContent(theContentManager, String.Format("Dugme\\{0}",tekstura2));
            stanje3.LoadContent(theContentManager, String.Format("Dugme\\{0}",tekstura3));
        }

        public override void Update(GameTime gameTime)
        {
            stanje1.Velicina = velicina * povecanje;
            stanje2.Velicina = velicina * povecanje;
            stanje3.Velicina = velicina * povecanje;
            doButtonWork(gameTime);
        }

        public override void Draw(SpriteBatch theSpriteBatch, Vector2 cameraPosition, Vector2 sredinaEkrana, float zumiranje)
        {
            if (stanje==0) stanje1.Draw(theSpriteBatch, cameraPosition-Pozicija, sredinaEkrana, zumiranje);
            else if (stanje==1) stanje2.Draw(theSpriteBatch, cameraPosition-Pozicija, sredinaEkrana, zumiranje);
            else stanje3.Draw(theSpriteBatch, cameraPosition-Pozicija, sredinaEkrana, zumiranje);
        }

        public virtual void doButtonWork(GameTime gameTime)
        {

        }

    }


}
