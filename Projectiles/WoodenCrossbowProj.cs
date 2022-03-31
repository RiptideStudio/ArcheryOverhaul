using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Projectiles
{
	public class WoodenCrossbowProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sand Proj2");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 8;
			projectile.height = 8;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.arrow = false;
			projectile.ranged = false;
			projectile.penetrate = 1;
			projectile.timeLeft = 1;
			projectile.light = 0f;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
			projectile.extraUpdates = 1;
		}

		public override void Kill(int timeLeft)
		{
			for (int i = 0; i < 4; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 16, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public WoodenCrossbowProj()
			
		{
		}
	}
}
