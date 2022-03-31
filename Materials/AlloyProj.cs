using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class AlloyProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Arrow");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 8;
			projectile.height = 17;
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
			Projectile.NewProjectile(center.X, center.Y, 0f, 0f, 612, 70, 4f, projectile.owner, 0f, 0f);
			for (int i = 0; i < 6; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("AlloyDust"), 0f, 0f, 0, default(Color), 1f);
			}
			for (int j = 0; j < 6; j++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("SteelDust"), 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
			}
			return true;
		}

		public override void AI()
		{
			if (Main.rand.Next(1) == 0)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("AlloyDust"), 0f, 0f, 0, default(Color), 1f);
			}
			if (Main.rand.Next(6) == 0)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			for (int i = 0; i < 6; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 6, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(projectile.position, projectile.width, projectile.height, mod.DustType("AlloyDust"), 0f, 0f, 0, default(Color), 1f);
			}
			Vector2 center = projectile.Center;
			Projectile.NewProjectile(center.X, center.Y, 0f, 0f, 612, 70, 4f, projectile.owner, 0f, 0f);
		}

		public AlloyProj()
			
		{
		}
	}
}
