using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Projectiles
{
	public class FrostProj : ModProjectile
	{
		private int dust_num = 135;

		private int dust_num2 = 213;

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
			projectile.penetrate = 2;
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
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 180, 0f, 0f, 0, default(Color), 1f);
			}
			Main.PlaySound(0, (int)projectile.position.X, (int)projectile.position.Y, 1, 1f, 0f);
			return true;
		}

		public override void AI()
		{
			projectile.position.Y += (float)Math.Sin(projectile.timeLeft) * -10f;
			projectile.position.X += (float)Math.Cos(projectile.timeLeft) * -10f;
			if (Main.rand.Next(1) == 0)
			{
				for (int i = 0; i < 2; i++)
				{
					Vector2 position = projectile.position;
					int num = Dust.NewDust(position, 1, 1, 135, 0f, 0f, 0, default(Color), 1f);
					Dust obj = Main.dust[num];
					obj.velocity *= 0.2f;
					Main.dust[num].scale = (float)Main.rand.Next(60, 175) * 0.013f;
					Main.dust[num].noGravity = true;
					int num2 = Dust.NewDust(position, 1, 1, 180, 0f, 0f, 0, default(Color), 1f);
					Dust obj2 = Main.dust[num2];
					obj2.velocity *= 0.2f;
					Main.dust[num2].scale = (float)Main.rand.Next(60, 175) * 0.013f;
					Main.dust[num2].noGravity = true;
				}
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			for (int i = 0; i < 7; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, dust_num, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 180, 0f, 0f, 0, default(Color), 1f);
			}
			target.AddBuff(44, 180, false);
		}

		public FrostProj()
			
		{
		}
	}
}
