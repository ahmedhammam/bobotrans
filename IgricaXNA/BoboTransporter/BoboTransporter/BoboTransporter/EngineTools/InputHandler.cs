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
        static bool blokiranoPotvrdjivanje = false;
        static bool blokiranoVracanje = false;
        static public void Update(GameTime gameTime)
        {
            myState = Keyboard.GetState();
            if (myState.IsKeyUp(Opcije.confirmClickedBtn)) blokiranoPotvrdjivanje = false;
            if (myState.IsKeyUp(Opcije.izadjiBtn)) blokiranoVracanje = false;
        }

        static public bool Naprijed
        {
            get
            {
                return (myState.IsKeyDown(Opcije.naprijed1Btn) || myState.IsKeyDown(Opcije.naprijed2Btn));
            }
        }

        static public bool Nazad
        {
            get
            {
                return (myState.IsKeyDown(Opcije.nazad1Btn) || myState.IsKeyDown(Opcije.nazad2Btn));
            }
        }

        static public bool Desno
        {
            get
            {
                return (myState.IsKeyDown(Opcije.desno1Btn) || myState.IsKeyDown(Opcije.desno2Btn));
            }
        }

        static public bool Lijevo
        {
            get
            {
                return (myState.IsKeyDown(Opcije.lijevo1Btn) || myState.IsKeyDown(Opcije.lijevo2Btn));
            }
        }

        static public bool GoreMeni
        {
            get
            {
                return (myState.IsKeyDown(Opcije.goreMeniBtn));
            }
        }

        static public bool DoleMeni
        {
            get
            {
                return (myState.IsKeyDown(Opcije.doleMeniBtn));
            }
        }
        static public bool DesnoMeni
        {
            get
            {
                return (myState.IsKeyDown(Opcije.desnoMeniBtn));
            }
        }
        static public bool LijevoMeni
        {
            get
            {
                return (myState.IsKeyDown(Opcije.lijevoMeniBtn));
            }
        }
        static public bool Exit
        {
            get
            {
                if (myState.IsKeyDown(Opcije.izadjiBtn) && !blokiranoVracanje)
                {
                    blokiranoVracanje = true;
                    return true;
                }
                else
                    return false;
            }
        }
        static public bool ConfirmClicked
        {
            get
            {

                if (myState.IsKeyDown(Opcije.confirmClickedBtn) && !blokiranoPotvrdjivanje)
                {
                    blokiranoPotvrdjivanje = true;
                    return true;
                }
                else
                return false;
            }
        }
    }
}
