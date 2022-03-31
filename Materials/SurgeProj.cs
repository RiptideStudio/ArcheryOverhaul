using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SurgeProj : ModProjectile
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
			projectile.penetrate = 2;
			projectile.timeLeft = 600;
			projectile.light = 0f;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			aiType = 1;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Vector2 center = projectile.Center;
			Main.PlaySound(0, (int)center.X, (int)center.Y, 1, 1f, 0f);
			for (int i = 0; i < 6; i++)
			{
				Dust.NewDust(projectile.position, projectile.width - 16, projectile.height - 32, 101, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width - 16, projectile.height - 32, 101, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width - 16, projectile.height - 32, 103, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width + 16, projectile.height - 32, 101, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width + 16, projectile.height - 32, 103, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width + 16, projectile.height - 32, 103, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			return true;
		}

		public override void AI()
		{
			projectile.velocity.Y = projectile.velocity.Y - 0.04f;
			if (projectile.velocity.Y > 16f)
			{
				projectile.velocity.Y = 16f;
			}

			Vector2 projectilePosition = new Vector2(projectile.position.X, projectile.position.Y);
			int dust = Dust.NewDust(projectilePosition, 0, 0, 34, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].velocity *= 0.4f;
			Main.dust[dust].scale = (float)Main.rand.Next(80, 115) * 0.013f;
			Main.dust[dust].noGravity = true;

			int dust2 = Dust.NewDust(projectilePosition, 0, 0, 29, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust2].velocity *= 0.4f;
			Main.dust[dust2].scale = (float)Main.rand.Next(80, 115) * 0.013f;
			Main.dust[dust2].noGravity = true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			Dust.NewDust(projectile.position, projectile.width - 32, projectile.height - 32, 101, 0f, 0f, 0, default(Color), 1f);
			Dust.NewDust(projectile.position, projectile.width - 32, projectile.height - 32, 101, 0f, 0f, 0, default(Color), 1f);
			Dust.NewDust(projectile.position, projectile.width - 32, projectile.height - 32, 103, 0f, 0f, 0, default(Color), 1f);
			Dust.NewDust(projectile.position, projectile.width + 32, projectile.height - 32, 101, 0f, 0f, 0, default(Color), 1f);
			Dust.NewDust(projectile.position, projectile.width + 32, projectile.height - 32, 103, 0f, 0f, 0, default(Color), 1f);
			Dust.NewDust(projectile.position, projectile.width + 32, projectile.height - 32, 103, 0f, 0f, 0, default(Color), 1f);
		}

		public SurgeProj()
			
		{
		}
	}
}
