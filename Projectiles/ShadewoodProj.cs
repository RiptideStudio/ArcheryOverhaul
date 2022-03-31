using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Projectiles
{
	public class ShadewoodProj : ModProjectile
	{
		private int dust_num = 258;

		private int dust_num2 = 258;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sand Proj2");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.height = 16;
			projectile.aiStyle = 0;
			projectile.magic = true;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
			projectile.light = 0f;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.extraUpdates = 1;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			for (int i = 0; i < 7; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, dust_num, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, dust_num2, 0f, 0f, 0, default(Color), 1f);
			}
			Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 1, 1f, 0f);
			return true;
		}

		public override void AI()
		{
			if (Main.rand.Next(1) == 0)
			{
				for (int i = 0; i < 2; i++)
				{
					Dust.NewDust(projectile.position, projectile.width, projectile.height, dust_num, 0f, 0f, 0, default(Color), 1f);
				}
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			for (int i = 0; i < 7; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, dust_num, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, dust_num2, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public ShadewoodProj()
			
		{
		}
	}
}
