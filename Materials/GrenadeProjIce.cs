using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class GrenadeProjIce : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.height = 20;
			projectile.aiStyle = 16;
			projectile.friendly = true;
			projectile.penetrate = -1;
			projectile.timeLeft = 170;
			projectile.hostile = false;
			drawOriginOffsetY = 0;
			drawOffsetX = 0;
		}

		
		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			Main.PlaySound(SoundID.Item14, (int)((Entity)target).position.X, (int)((Entity)target).position.Y);
			Dust.NewDust(projectile.position, projectile.width, projectile.height, 135, 0f, 0f, 0, default(Color), 1f);
		}

		public override void Kill(int timeLeft)
		{
			Player recipe = Main.player[projectile.owner];
			Vector2 center = projectile.Center;
			Main.PlaySound(SoundID.Item14, (int)center.X, (int)center.Y);
			Main.PlaySound(SoundID.Item5, (int)center.X, (int)center.Y);
			float num = 5f;
			float num2 = 0f;
			float num3 = 3f;
			for (int i = 0; i < 6; i++)
			{
				Vector2 vector = Utils.RotatedByRandom(new Vector2(num, num2), (double)MathHelper.ToRadians(360f));
				num = vector.X;
				num2 = vector.Y;
				Projectile.NewProjectile(center.X, center.Y, num, num2, 172, 18, num3, ((Entity)recipe).whoAmI, 0f, 0f);
			}
			for (int j = 0; j < 15; j++)
			{
				Main.rand.Next(-20, 20);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 132, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public override void AI()
		{
			Vector2 pos = new Vector2(projectile.position.X + projectile.velocity.X, projectile.position.Y - projectile.velocity.Y);
			int dust5 = Dust.NewDust(pos, projectile.width, projectile.height, 135);
			Main.dust[dust5].velocity.Y = projectile.velocity.Y * 0.3f;
			Main.dust[dust5].velocity.X = projectile.velocity.X * -0.3f;
		}

		public GrenadeProjIce()
			
		{
		}
	}
}
