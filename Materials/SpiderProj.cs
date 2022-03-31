using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SpiderProj : ModProjectile
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
			projectile.timeLeft = 120;
			projectile.light = 0f;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.extraUpdates = 1;
			aiType = 1;
			projectile.penetrate = 3;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Vector2 center = projectile.Center;
			Main.PlaySound(0, (int)center.X, (int)center.Y, 1, 1f, 0f);
			for (int i = 0; i < 6; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 22, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			return true;
		}

		public override void AI()
		{
			if (Main.rand.Next(2) == 0)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 22, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			Player recipe = Main.player[projectile.owner];
			Projectile.NewProjectile(((Entity)target).position.X, ((Entity)target).position.Y, 0f, 0f, 165, damage, knockback, ((Entity)recipe).whoAmI, 0f, 0f);
		}

		public SpiderProj()
			
		{
		}
	}
}
