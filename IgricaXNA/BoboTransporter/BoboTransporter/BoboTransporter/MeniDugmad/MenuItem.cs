using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter.MeniDugmad
{
    abstract class MenuItem
    {
        private bool isFocused;
        private string tooltip;
        Vector2 pozicija;

        public Vector2 Pozicija
        {
            get { return pozicija; }
            set { pozicija = value; }
        }

        public string Tooltip
        {
            get { return tooltip; }
            set { tooltip = value; }
        }

        public bool IsFocused
        {
            get { return isFocused; }
            set { isFocused = value; }
        }

        public abstract void LoadContent(ContentManager theContentManager);
        public abstract void Update(GameTime gameTime);
        public abstract void Draw(SpriteBatch theSpriteBatch, Vector2 cameraPosition, Vector2 sredinaEkrana, float zumiranje);
    }
}
