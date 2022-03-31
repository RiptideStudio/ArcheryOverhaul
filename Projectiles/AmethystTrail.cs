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

namespace bowmod.Projectiles
{
	public class AmethystTrail : ModProjectile
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
			projectile.timeLeft = 180;
			projectile.light = 0f;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.extraUpdates = 1;
			projectile.alpha = 200;
			projectile.scale = 0f;
		}

		public override bool PreDraw(SpriteBatch spriteBatch, Color lightColor)
		{

			if (projectile.scale < 1) projectile.scale += 0.1f;

			return true;
		}

		public override void AI()
		{
			projectile.aiStyle = 0;
			projectile.velocity = new Vector2(0, 0);
		}


	}
}
