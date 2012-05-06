using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using BoboTransporter.EngineTools;
using BoboTransporter.Meniji;

namespace BoboTransporter
{
    class IgraMenu
    {
        GlavniMeni glavniMeni;
        IzlazMeni izlazMeni;
        OpcijeMeni opcijeMeni;
        IgrajMeni igrajMeni;
        PomocMeni pomocMeni;
        WinMeni winMeni;
        LoseMeni loseMeni;
        PauzaMeni pauzaMeni;

        public IgraMenu()
        {
            glavniMeni = new GlavniMeni();
            izlazMeni = new IzlazMeni();
            opcijeMeni = new OpcijeMeni();
            igrajMeni = new IgrajMeni();
            pomocMeni = new PomocMeni();
            winMeni = new WinMeni();
            loseMeni = new LoseMeni();
            pauzaMeni = new PauzaMeni();
        }

        public virtual void LoadContent(ContentManager theContentManager)
        {
            glavniMeni.LoadContent(theContentManager);
            izlazMeni.LoadContent(theContentManager);
            opcijeMeni.LoadContent(theContentManager);
            igrajMeni.LoadContent(theContentManager);
            pomocMeni.LoadContent(theContentManager);
            winMeni.LoadContent(theContentManager);
            loseMeni.LoadContent(theContentManager);
            pauzaMeni.LoadContent(theContentManager);
        }

        public void Update(GameTime gameTime)
        {
            InputHandler.Update(gameTime);
            switch (Opcije.gamePointer.stanje)
            {
                case StanjeIgre.GLAVNI_MENI:
                    glavniMeni.Update(gameTime);
                    break;
                case StanjeIgre.IZADJI_MENI:
                    izlazMeni.Update(gameTime);
                    break;
                case StanjeIgre.OPCIJE_MENI:
                    opcijeMeni.Update(gameTime);
                    break;
                case StanjeIgre.POCNI_IGRU_MENI:
                    igrajMeni.Update(gameTime);
                    break;
                case StanjeIgre.POMOC:
                    pomocMeni.Update(gameTime);
                    break;
                case StanjeIgre.WIN_MENI:
                    winMeni.Update(gameTime);
                    break;
                case StanjeIgre.LOSE_MENI:
                    loseMeni.Update(gameTime);
                    break;
                case StanjeIgre.PAUZA_MENI:
                    pauzaMeni.Update(gameTime);
                    break;
            }
        }

        public virtual void Draw(GameTime gameTime, SpriteBatch theSpriteBatch, Vector2 sredinaEkrana)
        {
            theSpriteBatch.Begin(SpriteSortMode.FrontToBack, BlendState.AlphaBlend);
            switch (Opcije.gamePointer.stanje)
            {
                case StanjeIgre.GLAVNI_MENI:
                    glavniMeni.Draw(theSpriteBatch, sredinaEkrana, 1f);
                    break;
                case StanjeIgre.IZADJI_MENI:
                    izlazMeni.Draw(theSpriteBatch, sredinaEkrana, 1f);
                    break;
                case StanjeIgre.OPCIJE_MENI:
                    opcijeMeni.Draw(theSpriteBatch, sredinaEkrana, 1f);
                    break;
                case StanjeIgre.POCNI_IGRU_MENI:
                    igrajMeni.Draw(theSpriteBatch, sredinaEkrana, 1f);
                    break;
                case StanjeIgre.POMOC:
                    pomocMeni.Draw(theSpriteBatch, sredinaEkrana, 1f);
                    break;
                case StanjeIgre.WIN_MENI:
                    winMeni.Draw(theSpriteBatch, sredinaEkrana, 1f);
                    break;
                case StanjeIgre.LOSE_MENI:
                    loseMeni.Draw(theSpriteBatch, sredinaEkrana, 1f);
                    break;
                case StanjeIgre.PAUZA_MENI:
                    pauzaMeni.Draw(theSpriteBatch, sredinaEkrana, 1f);
                    break;
            }
            theSpriteBatch.End();
        }
    }
}
