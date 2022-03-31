using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SnowProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Arrow");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 16;
			projectile.arrow = true;
			projectile.height = 7;
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

		public override void AI()
		{
			if (Main.rand.Next(5) == 0)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 212, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			for (int i = 0; i < 3; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 212, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 212, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 212, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			Main.PlaySound(SoundID.Item10, projectile.position);
			Player recipe = Main.player[projectile.owner];
			Vector2 center = projectile.Center;
			float num = 5f;
			float num2 = 0f;
			float num3 = 3f;
			for (int j = 0; j < 5; j++)
			{
				Vector2 vector = Utils.RotatedByRandom(new Vector2(num, num2), (double)MathHelper.ToRadians(360f));
				num = vector.X;
				num2 = vector.Y;
				Projectile.NewProjectile(center.X, center.Y, num, num2, 166, 6, num3, ((Entity)recipe).whoAmI, 0f, 0f);
			}
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			for (int i = 0; i < 3; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 212, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 212, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 212, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			Main.PlaySound(SoundID.Item10, projectile.position);
			Player recipe = Main.player[projectile.owner];
			Vector2 center = projectile.Center;
			float num = 5f;
			float num2 = 0f;
			float num3 = 3f;
			for (int j = 0; j < 5; j++)
			{
				Vector2 vector = Utils.RotatedByRandom(new Vector2(num, num2), (double)MathHelper.ToRadians(360f));
				num = vector.X;
				num2 = vector.Y;
				Projectile.NewProjectile(center.X, center.Y, num, num2, 166, 6, num3, ((Entity)recipe).whoAmI, 0f, 0f);
			}
			return true;
		}

		public SnowProj()
			
		{
		}
	}
}
