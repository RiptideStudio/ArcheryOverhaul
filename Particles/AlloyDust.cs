using Terraria;
using Terraria.ModLoader;

namespace bowmod.Particles
{
	public class AlloyDust : ModDust
	{
		public override void OnSpawn(Dust dust)
		{
			dust.velocity *= 0.6f;
			dust.noGravity = true;
			dust.noLight = true;
			dust.scale *= 2f;
		}

		public override bool Update(Dust dust)
		{
			dust.position += dust.velocity;
			dust.rotation += dust.velocity.X * 0.2f;
			dust.scale *= 0.9f;
			if (dust.scale < 0.5f)
			{
				dust.active = false;
			}
			return false;
		}

		public AlloyDust()
			
		{
		}
	}
}
