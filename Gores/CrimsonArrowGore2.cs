using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace bowmod.Gores
{
	public class CrimsonArrowGore2 : ModGore
	{
		public override void OnSpawn(Gore gore)
		{
			gore.velocity = new Vector2(Utils.NextFloat(Main.rand, 2f, -2f), Utils.NextFloat(Main.rand, 2f, -2f));
			gore.numFrames = 1;
			gore.frame = 1;
			gore.frameCounter = 1;
			gore.rotation = MathHelper.ToRadians(360f);
			gore.timeLeft = 15;
		}

		public CrimsonArrowGore2()
			
		{
		}
	}
}
