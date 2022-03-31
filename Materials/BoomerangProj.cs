using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class BoomerangProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Arrow");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.width = 14;
			projectile.arrow = true;
			projectile.height = 14;
			projectile.aiStyle = 3;
			projectile.friendly = true;
			projectile.hostile = false;
			projectile.ranged = true;
			projectile.penetrate = 1;
			projectile.timeLeft = 600;
			projectile.light = 0f;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.extraUpdates = 1;
			projectile.CloneDefaults(6);
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			Main.PlaySound(0, -1, -1, 1, 1f, 0f);
			for (int i = 0; i < 6; i++)
			{
				Dust.NewDust(projectile.position, projectile.width, projectile.height, 7, 0f, 0f, 0, default(Color), 1f);
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
			Player recipe = Main.player[projectile.owner];
			_ = Main.npc[(int)projectile.ai[0]];
			float num = 0f;
			float num2 = Main.rand.Next(-50, 50);
			Main.rand.Next(-8, 8);
			Main.rand.Next(0, 10);
			if (projectile.timeLeft % 15 == 1)
			{
				Projectile.NewProjectile(projectile.position.X, projectile.position.Y, num + num2, -8f, 1, 12, 3f, ((Entity)recipe).whoAmI, 0f, 0f);
				Projectile.NewProjectile(projectile.position.X, projectile.position.Y, num + num2, 8f, 1, 12, 3f, ((Entity)recipe).whoAmI, 0f, 0f);
			}
		}

		public BoomerangProj()
			
		{
		}
	}
}
