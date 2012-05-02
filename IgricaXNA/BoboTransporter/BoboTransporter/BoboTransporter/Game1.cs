using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using BoboTransporter.Grafika;

namespace BoboTransporter
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        IgraPokrenuta igra;
        //Texture2D bijelo;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            graphics.IsFullScreen = false;
            graphics.PreferredBackBufferHeight = 768;
            graphics.PreferredBackBufferWidth = 1024;
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            igra = new IgraPokrenuta(5, 5, false);

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            
            // TODO: use this.Content to load your game content here
            igra.LoadContent(this.Content);
            //bijelo = this.Content.Load<Texture2D>("bijeloTekstura");
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            if (EngineTools.InputHandler.Exit)
                this.Exit();

            // TODO: Add your update logic here
            igra.Update(gameTime);
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here

            igra.Draw(gameTime, spriteBatch, new Vector2(graphics.PreferredBackBufferWidth / 2, graphics.PreferredBackBufferHeight / 2));

            /*
            //SUNSET
            boja = Color.FromNonPremultiplied(255, 235, 153, 255);
            //DAWN
            boja = Color.FromNonPremultiplied(255, 235, 153, 255);
            //NIGHT
            boja = Color.FromNonPremultiplied(27, 27, 27, 255);
            //DAY
            boja = Color.FromNonPremultiplied(235, 235, 235, 255);
             *
            */
            /*spriteBatch.Begin(SpriteSortMode.Immediate, BlendState.Additive);
            Color boja = Color.Red;
            spriteBatch.Draw(bijelo,new Rectangle(0,0,graphics.PreferredBackBufferWidth,graphics.PreferredBackBufferHeight),boja);
            spriteBatch.End();
            base.Draw(gameTime);*/
        }
    }
}
