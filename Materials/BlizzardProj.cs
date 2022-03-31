using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class BlizzardProj : ModProjectile
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
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.extraUpdates = 1;
			aiType = 1;
			projectile.CloneDefaults(1);
		}

		public override void AI()
		{
			if (Main.rand.Next(6) == 0)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 212, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 135, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			for (int i = 0; i < 3; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 212, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 135, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 212, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			Main.PlaySound(SoundID.Item10, projectile.position);
			Player recipe = Main.player[projectile.owner];
			
			for (int j = 0; j < 3; j++)
			{
				float x = 1f;
				float y = 6f;
				float num = 2f;
				int num2 = Main.rand.Next(-200, 200);
				int num3 = Main.rand.Next(-400, 400);
				Vector2 vector = Utils.RotatedByRandom(new Vector2(x, y), (double)MathHelper.ToRadians(120f));
				x = vector.X;
				y = vector.Y;
				Projectile.NewProjectile(projectile.position.X + (float)num3, ((Entity)recipe).position.Y - 550f - (float)num2, x, y, 166, 8, num, projectile.owner, 0f, 0f);
			}
			for (int k = 0; k < 3; k++)
			{
				float x2 = 0f;
				float y2 = 6f;
				float num4 = 2f;
				int num5 = Main.rand.Next(-200, 200);
				int num6 = Main.rand.Next(-400, 400);
				Vector2 vector2 = Utils.RotatedByRandom(new Vector2(x2, y2), (double)MathHelper.ToRadians(120f));
				x2 = vector2.X;
				y2 = vector2.Y;
				Projectile.NewProjectile(projectile.position.X + (float)num6, ((Entity)recipe).position.Y - 550f - (float)num5, x2, y2, 172, 12, num4, projectile.owner, 0f, 0f);
			}
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			for (int i = 0; i < 3; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 212, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 135, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 212, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			Main.PlaySound(SoundID.Item10, projectile.position);
			Player recipe = Main.player[projectile.owner];

			for (int j = 0; j < 3; j++)
			{
				float x = 1f;
				float y = 6f;
				float num = 2f;
				int num2 = Main.rand.Next(-200, 200);
				int num3 = Main.rand.Next(-400, 400);
				Vector2 vector = Utils.RotatedByRandom(new Vector2(x, y), (double)MathHelper.ToRadians(120f));
				x = vector.X;
				y = vector.Y;
				Projectile.NewProjectile(projectile.position.X + (float)num3, ((Entity)recipe).position.Y - 550f - (float)num2, x, y, 166, 8, num, projectile.owner, 0f, 0f);
			}
			for (int k = 0; k < 3; k++)
			{
				float x2 = 0f;
				float y2 = 6f;
				float num4 = 2f;
				int num5 = Main.rand.Next(-200, 200);
				int num6 = Main.rand.Next(-400, 400);
				Vector2 vector2 = Utils.RotatedByRandom(new Vector2(x2, y2), (double)MathHelper.ToRadians(120f));
				x2 = vector2.X;
				y2 = vector2.Y;
				Projectile.NewProjectile(projectile.position.X + (float)num6, ((Entity)recipe).position.Y - 550f - (float)num5, x2, y2, 172, 12, num4, projectile.owner, 0f, 0f);
			}
			return true;
		}

		public BlizzardProj()
			
		{
		}
	}
}
