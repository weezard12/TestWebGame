using Microsoft.Xna.Framework.Graphics;
using Nez;
using Nez.Sprites;
using Nez.Textures;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestWebGame
{
    internal class FEntity : Entity
    {
        public FEntity()
        {
            AddComponent(new SpriteRenderer(new Sprite(TestWebGameGame.ds)));
        }
        public override void Update()
        {
            base.Update();
            Debug.Log("c");
        }
    }
}
