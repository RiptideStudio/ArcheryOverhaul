using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class ExplosiveProj : ModProjectile
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
			projectile.hostile = false;
			projectile.friendly = true;
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

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Vector2 center = projectile.Center;
			Main.PlaySound(0, (int)center.X, (int)center.Y, 1, 1f, 0f);
			for (int i = 0; i < 6; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			_ = Main.player[projectile.owner];
			Main.PlaySound(SoundID.Item14, (int)center.X, (int)center.Y);
			Projectile.NewProjectile(center.X, center.Y, 0f, 0f, mod.ProjectileType("ExplodeSplash"), 24, 4f, projectile.owner, 0f, 0f);
			Projectile.NewProjectile(center.X, center.Y, 0f, 0f, mod.ProjectileType("ExplosionLarge"), 0, 4f, projectile.owner, 0f, 0f);
			for (int j = 0; j < 15; j++)
			{
				Main.rand.Next(-20, 20);
				Dust.NewDust(center, 22, 22, 6, 0f, 0f, 120, default(Color), 1f);
				Dust.NewDust(center, 22, 22, 7, 0f, 0f, 120, default(Color), 1f);
				Dust.NewDust(center, 22, 22, 16, 0f, 0f, 120, default(Color), 1f);
			}
			return true;
		}

		public override void AI()
		{
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			_ = Main.player[projectile.owner];
			Vector2 center = projectile.Center;
			Main.PlaySound(SoundID.Item14, (int)center.X, (int)center.Y);
			Projectile.NewProjectile(((Entity)target).position.X, ((Entity)target).position.Y, 0f, 0f, mod.ProjectileType("ExplodeSplash"), damage / 2, knockback, projectile.owner, 0f, 0f);
			Projectile.NewProjectile(((Entity)target).position.X, ((Entity)target).position.Y, 0f, 0f, mod.ProjectileType("ExplosionLarge"), 0, knockback, projectile.owner, 0f, 0f);
			for (int i = 0; i < 15; i++)
			{
				Main.rand.Next(-20, 20);
				Dust.NewDust(center, 22, 22, 6, 0f, 0f, 120, default(Color), 1f);
				Dust.NewDust(center, 22, 22, 7, 0f, 0f, 120, default(Color), 1f);
				Dust.NewDust(center, 22, 22, 16, 0f, 0f, 120, default(Color), 1f);
			}
		}

		public ExplosiveProj()
			
		{
		}
	}
}
