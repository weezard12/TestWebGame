
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Input.Touch;
using Microsoft.Xna.Framework.Media;
using Nez;
using Nez.BitmapFonts;
using System;
using System.Collections.Generic;


namespace TestWebGame
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class TestWebGameGame : Core
    {

        protected override void Initialize()
        {
            //var font = Content.Load<BitmapFont>("nez://Nez.Content.NezDefaultBMFont.xnb");

            base.Initialize();
            //Scene = new FScene();
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
            Debug.Log("aaa");
        }
    }
}
