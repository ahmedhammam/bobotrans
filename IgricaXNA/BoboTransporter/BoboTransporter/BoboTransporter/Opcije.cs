using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BoboTransporter
{
    static class Opcije
    {
        static public Keys naprijed1Btn = Keys.W;
        static public Keys naprijed2Btn = Keys.None;
        static public Keys nazad1Btn = Keys.S;
        static public Keys nazad2Btn = Keys.None;
        static public Keys lijevo1Btn = Keys.A;
        static public Keys lijevo2Btn = Keys.None;
        static public Keys desno1Btn = Keys.D;
        static public Keys desno2Btn = Keys.None;
        static public Keys goreMeniBtn = Keys.Up;
        static public Keys doleMeniBtn = Keys.Down;
        static public Keys lijevoMeniBtn = Keys.Left;
        static public Keys desnoMeniBtn = Keys.Right;
        static public Keys izadjiBtn = Keys.Escape;
        static public Keys confirmClickedBtn = Keys.Enter;
        static public bool mapaUkljucena = true;
        static public bool brzinomjerUkljucen = true;
        static public bool vrijemeUkljuceno = true;
        static public Game1 gamePointer;
        static public int snijegNaMapi = 0;
        static public int dimenzijaMape = 5;
        static public Texture2D pozadina;
        static public Texture2D pozadinaOsnovno;
        static public string porukaGubitak;
    }
}
