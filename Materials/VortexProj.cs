using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class VortexProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Arrow");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 12;
			projectile.arrow = true;
			projectile.height = 16;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.ranged = true;
			projectile.penetrate = 5;
			projectile.timeLeft = 600;
			projectile.light = 0f;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
			projectile.extraUpdates = 1;
			aiType = 1;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Vector2 center = projectile.Center;
			Main.PlaySound(0, (int)center.X, (int)center.Y, 1, 1f, 0f);
			for (int i = 0; i < 6; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 131, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 131, 0f, 0f, 0, default(Color), 1f);
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
			if (Main.rand.Next(3) == 0)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 131, 0f, 0f, 0, default(Color), 1f);
			}
			if (projectile.alpha > 70)
			{
				
				projectile.alpha -= 15;
				if (projectile.alpha < 70)
				{
					projectile.alpha = 70;
				}
			}
			if (projectile.localAI[0] == 0f)
			{
				AdjustMagnitude(ref projectile.velocity);
				projectile.localAI[0] = 1f;
			}
			Vector2 vector = Vector2.Zero;
			float num = 250f;
			bool flag = false;
			for (int i = 0; i < 200; i++)
			{
				if (((Entity)Main.npc[i]).active && !Main.npc[i].dontTakeDamage && !Main.npc[i].friendly && Main.npc[i].lifeMax > 5)
				{
					Vector2 vector2 = Main.npc[i].Center - projectile.Center;
					float num2 = (float)Math.Sqrt(vector2.X * vector2.X + vector2.Y * vector2.Y);
					if (num2 < num)
					{
						vector = vector2;
						num = num2;
						flag = true;
					}
				}
			}
			if (flag)
			{
				AdjustMagnitude(ref vector);
				projectile.velocity = (5f * projectile.velocity + vector) / 2f;
				AdjustMagnitude(ref projectile.velocity);
			}
		}

		private void AdjustMagnitude(ref Vector2 vector)
		{
			float num = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
			if (num > 8.5f)
			{
				vector *= 8.5f / num;
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			_ = Main.player[projectile.owner];
			for (int i = 0; i < 6; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 131, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 131, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public VortexProj()
			
		{
		}
	}
}
