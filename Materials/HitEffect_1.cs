using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class HitEffect_1 : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Arrow");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
			Main.projFrames[projectile.type] = 4;
		}

		public override void SetDefaults()
		{
			projectile.width = 24;
			projectile.arrow = false;
			projectile.ranged = false;
			projectile.height = 24;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.penetrate = 9999;
			projectile.light = 0f;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
			projectile.timeLeft = 200;
			projectile.extraUpdates = 1;
			aiType = 1;
			Main.projFrames[projectile.type] = 4;
		}

		public override void AI()
		{
			projectile.velocity.Y = 0f;
			projectile.velocity.X = 0f;
			
			if (++projectile.frameCounter >= 4)
			{
				projectile.frameCounter = 0;
				Projectile projectile2 = projectile;
				if (++projectile2.frame >= 4)
				{
					projectile.Kill();
				}
			}
		}

		public HitEffect_1()
			
		{
		}
	}
}
