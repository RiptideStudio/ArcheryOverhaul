using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SkyProj : ModProjectile
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
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
			projectile.light = 0f;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.extraUpdates = 1;
			aiType = 1;
			projectile.CloneDefaults(1);
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Vector2 center = projectile.Center;
			Main.PlaySound(0, (int)center.X, (int)center.Y, 1, 1f, 0f);
			for (int i = 0; i < 6; i++)
			{
				Dust.NewDust(projectile.position, projectile.width - 16, projectile.height - 32, 101, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			return true;
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			Dust.NewDust(projectile.position, projectile.width - 32, projectile.height - 32, 101, 0f, 0f, 0, default(Color), 1f);
			float num = 0f;
			float num2 = 12f;
			float num3 = 3f;
			int num4 = 14;
			for (int i = 0; i < 3; i++)
			{
				int num5 = Main.rand.Next(100);
				int num6 = Main.rand.Next(-25, 25);
				Vector2 vector = Utils.RotatedByRandom(new Vector2(num, num2), (double)MathHelper.ToRadians(20f));
				num = vector.X;
				num2 = vector.Y;
				Player recipe = Main.player[projectile.owner];
				Projectile.NewProjectile(((Entity)target).position.X + (float)num6, ((Entity)recipe).position.Y - 600f - (float)num5, num, num2, 1, num4, num3, projectile.owner, 0f, 0f);
			}
		}

		public SkyProj()
			
		{
		}
	}
}
