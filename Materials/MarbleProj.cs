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
	public class MarbleProj : ModProjectile
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
			projectile.timeLeft = 1200;
			projectile.light = 2f;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.extraUpdates = 6;
			projectile.CloneDefaults(5);
			projectile.penetrate = 3;
			projectile.timeLeft = 400;

		}
		float multiplier = 1f;
		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Vector2 center = projectile.Center;
			Main.PlaySound(0, (int)center.X, (int)center.Y, 1, 1f, 0f);
			for (int i = 0; i < 6; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 204, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			return true;
		}

		public override void AI()
		{
			if (multiplier > 0) multiplier -= 0.05f;
			Vector2 offset = new Vector2(projectile.velocity.X*2, projectile.velocity.Y*2);
			projectile.aiStyle = 0;
			Vector2 projectilePosition = new Vector2(projectile.position.X, projectile.position.Y);
			int dust = Dust.NewDust(projectilePosition-offset, 0, 0, 204, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust].velocity = projectile.velocity * multiplier;
			Main.dust[dust].scale = (float)Main.rand.Next(80, 115) * 0.013f;
			Main.dust[dust].noGravity = true;
		}



	}
}
