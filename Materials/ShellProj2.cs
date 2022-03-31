using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class ShellProj2 : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sand Proj2");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 38;
			projectile.height = 24;
			projectile.aiStyle = 2;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.arrow = true;
			projectile.ranged = true;
			projectile.penetrate = 999;
			projectile.timeLeft = 300;
			projectile.light = 0f;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.extraUpdates = 1;
			aiType = 1;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			for (int i = 0; i < 12; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			return true;
		}

		public override void AI()
		{
			projectile.velocity.Y = projectile.velocity.Y - 0.07f;
			if (projectile.velocity.Y > 16f)
			{
				projectile.velocity.Y = 16f;
			}
		}

		public ShellProj2()
			
		{
		}
	}
}
