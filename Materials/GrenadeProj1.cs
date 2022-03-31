using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class GrenadeProj1 : ModProjectile
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
			drawOffsetX = 0;
			drawOriginOffsetY = 0;
		}


		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			Main.PlaySound(SoundID.Item14, (int)((Entity)target).position.X, (int)((Entity)target).position.Y);
			Dust.NewDust(projectile.Center, 22, 22, 31, 0f, 0f, 120, default(Color), 1f);
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
				Projectile.NewProjectile(center.X, center.Y, num, num2, 1, 15, num3, ((Entity)recipe).whoAmI, 0f, 0f);
			}
			for (int j = 0; j < 15; j++)
			{
				Main.rand.Next(-20, 20);
				Dust.NewDust(center, 22, 22, 6, 0f, 0f, 120, default(Color), 1f);
				Dust.NewDust(center, 22, 22, 7, 0f, 0f, 120, default(Color), 1f);
				Dust.NewDust(center, 22, 22, 16, 0f, 0f, 120, default(Color), 1f);
			}
		}

		public GrenadeProj1()
			
		{
		}
	}
}
