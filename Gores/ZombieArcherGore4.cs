using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace bowmod.Gores
{
	public class ZombieArcherGore4 : ModGore
	{
		public override void OnSpawn(Gore gore)
		{
			gore.velocity = new Vector2(Utils.NextFloat(Main.rand, 4f, -4f), Utils.NextFloat(Main.rand, 4f, -4f));
			gore.numFrames = 1;
			gore.frame = 1;
			gore.frameCounter = 1;
			gore.rotation = MathHelper.ToRadians(360f);
			gore.sticky = false;
			gore.timeLeft = 120;
		}

		public ZombieArcherGore4()
			
		{
		}
	}
}
