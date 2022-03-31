using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class TrueRedProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Arrow");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 8;
			projectile.arrow = true;
			projectile.height = 8;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.ranged = true;
			projectile.penetrate = 10;
			projectile.timeLeft = 600;
			projectile.light = 1f;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.extraUpdates = 1;
			aiType = 1;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Vector2 center = projectile.Center;
			Main.PlaySound(0, (int)center.X, (int)center.Y, 1, 1f, 0f);
			for (int i = 0; i < 6; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 117, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 90, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 60, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			return true;
		}

		public override void AI()
		{
			projectile.velocity.Y = projectile.velocity.Y - 0.06f;
			if (projectile.velocity.Y > 16f)
			{
				projectile.velocity.Y = 16f;
			}
			if (Main.rand.Next(2) == 0)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 60, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 60, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 60, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			if (target.type != 488)
			{
				Player obj = Main.player[projectile.owner];
				int num = damage / 20;
				if (num >= 4)
				{
					num = 2;
				}
				if (num <= 0)
				{
					num = 1;
				}
				obj.statLife += num;
				obj.HealEffect(num, true);
			}
		}

		public TrueRedProj()
			
		{
		}
	}
}
