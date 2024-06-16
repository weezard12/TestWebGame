using Microsoft.Xna.Framework;
using Nez;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestWebGame
{
    internal class FScene : Scene
    {
        public FScene()
        {
            AddEntity(new FEntity());
            ClearColor = Color.Red;
        }
        public override void Update()
        {
            base.Update();
        }
    }
}
