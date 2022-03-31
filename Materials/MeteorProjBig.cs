using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class MeteorProjBig : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sand Proj2");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 8;
			projectile.height = 8;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.arrow = true;
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
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			Player recipe = Main.player[projectile.owner];
			Vector2 center = projectile.Center;
			Main.PlaySound(SoundID.Item14, (int)center.X, (int)center.Y);
			for (int i = 0; i < 15; i++)
			{
				Main.rand.Next(-20, 20);
				Dust.NewDust(center, 22, 22, 6, 0f, 0f, 120, default(Color), 1f);
				Dust.NewDust(center, 22, 22, 7, 0f, 0f, 120, default(Color), 1f);
				Dust.NewDust(center, 22, 22, 16, 0f, 0f, 120, default(Color), 1f);
			}
			for (int j = 0; j < 3; j++)
			{
				float num = 0f;
				float num2 = 8f;
				float num3 = Main.rand.Next(-1, 2);
				Projectile.NewProjectile(((Entity)target).position.X, ((Entity)recipe).position.Y - 400f, num + num3, num2, 425, damage * 2, knockback, ((Entity)recipe).whoAmI, 0f, 0f);
			}
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			_ = Main.player[projectile.owner];
			Vector2 center = projectile.Center;
			Main.PlaySound(SoundID.Item14, (int)center.X, (int)center.Y);
			for (int i = 0; i < 15; i++)
			{
				Main.rand.Next(-20, 20);
				Dust.NewDust(center, 22, 22, 6, 0f, 0f, 120, default(Color), 1f);
				Dust.NewDust(center, 22, 22, 7, 0f, 0f, 120, default(Color), 1f);
				Dust.NewDust(center, 22, 22, 16, 0f, 0f, 120, default(Color), 1f);
			}
			return true;
		}

		public MeteorProjBig()
			
		{
		}
	}
}
