using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SplitProj2 : ModProjectile
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
			projectile.timeLeft = 600;
			projectile.light = 0f;
			projectile.ignoreWater = true;
			projectile.tileCollide = true;
			projectile.extraUpdates = 1;
			aiType = 1;
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
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			Main.PlaySound(mod.GetLegacySoundSlot((SoundType)50, "Sounds/ArrowHit").WithVolume(0.3f)
				.WithPitchVariance(0.5f), -1, -1);
		}

		public SplitProj2()
			
		{
		}
	}
}
