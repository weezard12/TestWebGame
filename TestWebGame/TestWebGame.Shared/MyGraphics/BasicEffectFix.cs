using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace TestWebGame.MyGraphics
{
    internal class BasicEffectFix : BasicEffect
    {
        EffectParameter _matrixTransformParam;
        public BasicEffectFix(GraphicsDevice device) : base(device)
        {
            _matrixTransformParam = Parameters["MatrixTransform"];
        }

        protected BasicEffectFix(BasicEffect cloneSource) : base(cloneSource)
        {
        }
        public void SetMatrixTransform(ref Matrix matrixTransform)
        {
            _matrixTransformParam.SetValue(matrixTransform);
        }
    }
}
