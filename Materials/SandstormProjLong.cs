using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SandstormProjLong : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Arrow");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 32;
			projectile.arrow = true;
			projectile.height = 40;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.ranged = true;
			projectile.penetrate = 999;
			projectile.timeLeft = 600;
			projectile.light = 0f;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
			projectile.timeLeft = 180;
			projectile.extraUpdates = 1;
			aiType = 1;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			return true;
		}

		public override void AI()
		{
			projectile.velocity.Y = projectile.velocity.Y - 0.08f;
			if (projectile.velocity.Y > 16f)
			{
				projectile.velocity.Y = 1f;
			}
			if (Main.rand.Next(1) == 0)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 32, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
		}

		public SandstormProjLong()
			
		{
		}
	}
}
