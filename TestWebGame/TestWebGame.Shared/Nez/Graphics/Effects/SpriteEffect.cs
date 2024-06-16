using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace Nez
{
	public class SpriteEffect : Microsoft.Xna.Framework.Graphics.SpriteEffect
    {
		EffectParameter _matrixTransformParam;


		public SpriteEffect() : base(Core.GraphicsDevice)
		{
		}


		public void SetMatrixTransform(ref Matrix matrixTransform)
		{

        }
	}
}