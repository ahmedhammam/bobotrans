using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace BoboTransporter.EngineTools
{
    static class InputHandler
    {
        static KeyboardState myState;
        static public void Update(GameTime gameTime)
        {
            myState = Keyboard.GetState();
        }

        static public bool Up
        {
            get
            {
                return myState.IsKeyDown(Keys.W);
            }
        }

        static public bool Down
        {
            get
            {
                return myState.IsKeyDown(Keys.S);
            }
        }

        static public bool Right
        {
            get
            {
                return myState.IsKeyDown(Keys.D);
            }
        }

        static public bool Left
        {
            get
            {
                return myState.IsKeyDown(Keys.A);
            }
        }

        static public bool Exit
        {
            get
            {
                return myState.IsKeyDown(Keys.Escape);
            }
        }
    }
}
