using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Diagnostics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class MeteorProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sand Proj2");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 12;
			projectile.height = 12;
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
			aiType = 1;
			projectile.CloneDefaults(1);
		}


		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{
			//Redraw the projectile with the color not influenced by light
			Vector2 drawOrigin = new Vector2(Main.projectileTexture[projectile.type].Width * 0.5f, projectile.height * 0.5f);
			for (int k = 0; k < projectile.oldPos.Length; k++)
			{
				Vector2 drawPos = projectile.oldPos[k] - Main.screenPosition + drawOrigin + new Vector2(0f, projectile.gfxOffY);
				Color color = projectile.GetAlpha(lightColor) * ((float)(projectile.oldPos.Length - k) / (float)projectile.oldPos.Length);
				spriteBatch.Draw(Main.projectileTexture[projectile.type], drawPos, new Rectangle(0, projectile.frame * (Main.projectileTexture[projectile.type].Height / Main.projFrames[projectile.type]), Main.projectileTexture[projectile.type].Width, Main.projectileTexture[projectile.type].Height / Main.projFrames[projectile.type]), color, projectile.rotation, drawOrigin, projectile.scale, SpriteEffects.None, 0f);
			}
			return false;
		}

		public override void AI()
		{
			projectile.aiStyle = 0;
			projectile.extraUpdates = 2;
			Vector2 projectilePosition = new Vector2(projectile.position.X-projectile.velocity.X*4, projectile.position.Y - projectile.velocity.Y * 4);
			int dust = Dust.NewDust(projectilePosition, 0, 0, 6, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].velocity *= 0.6f;
			Main.dust[dust].scale = (float)Main.rand.Next(80, 115) * 0.013f;
			Main.dust[dust].noGravity = true;
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
			float num = 0f;
			float num2 = 9f;
			float num3 = Main.rand.Next(0, 1);
			var proj = Projectile.NewProjectile(((Entity)target).Center.X, ((Entity)target).Center.Y - 400f, projectile.velocity.X/100, num2, 424, damage, knockback*5, ((Entity)recipe).whoAmI, 0f, 0f);
			Main.projectile[proj].tileCollide = false;
			Main.projectile[proj].timeLeft = 1200;
			for (var i = 0; i < 255; i++)
			{
				if (Main.projectile[i].type == 425)
				{
					Main.projectile[i].timeLeft = 0;
					break;
				}
			}
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			_ = Main.player[projectile.owner];
			Vector2 center = projectile.Center;

			for (int i = 0; i < 15; i++)
			{
				Main.rand.Next(-20, 20);
				Dust.NewDust(center, 22, 22, 6, 0f, 0f, 120, default(Color), 1f);
				Dust.NewDust(center, 22, 22, 7, 0f, 0f, 120, default(Color), 1f);
				Dust.NewDust(center, 22, 22, 16, 0f, 0f, 120, default(Color), 1f);
			}
			return true;
		}

		public override void Kill(int timeLeft)
        {
			Projectile.NewProjectile(projectile.Center.X, projectile.Center.Y, 0f, 0f, mod.ProjectileType("ExplosionLarge"), 0, 4f, projectile.owner, 0f, 0f);
		}

	}
}
