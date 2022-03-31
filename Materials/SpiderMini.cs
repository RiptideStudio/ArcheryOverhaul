using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SpiderMini : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Arrow");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 22;
			projectile.height = 16;
			projectile.aiStyle = 16;
			projectile.friendly = true;
			projectile.penetrate = 999;
			projectile.timeLeft = 170;
			projectile.hostile = false;
		}

		public SpiderMini()
			
		{
		}
	}
}
