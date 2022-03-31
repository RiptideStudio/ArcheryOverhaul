using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class CrystalProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Arrow");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 11;
			projectile.arrow = true;
			projectile.height = 18;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = false;
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
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 164, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			return true;
		}

		public override void AI()
		{
			if (Main.rand.Next(1) == 0)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 164, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			for (int i = 0; i < 1; i++)
			{
				Player recipe = Main.player[projectile.owner];
				_ = Main.npc[(int)projectile.ai[0]];
				Main.rand.Next(-50, 50);
				Main.rand.Next(-8, 8);
				Projectile.NewProjectile(projectile.position.X, projectile.position.Y, 2f, 2f, 89, 32, 3f, ((Entity)recipe).whoAmI, 0f, 0f);
			}
		}

		public CrystalProj()
			
		{
		}
	}
}
