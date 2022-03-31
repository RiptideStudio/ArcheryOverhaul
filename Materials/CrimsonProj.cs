using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class CrimsonProj : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Purple Arrow");
			ProjectileID.Sets.TrailCacheLength[projectile.type] = 5;
			ProjectileID.Sets.TrailingMode[projectile.type] = 0;
		}

		public override void SetDefaults()
		{
			projectile.arrow = true;
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
			projectile.width = 8;
			projectile.height = 8;
		}

        int dust_num = 117;
        int dust_num2 = 7;


        public override void AI()
        {
            projectile.aiStyle = 1;
            Vector2 projectilePosition = new Vector2(projectile.position.X, projectile.position.Y);
            int dust = Dust.NewDust(projectilePosition, 0, 0, dust_num, 0f, 0f, 0, default(Color), 1f);
            Main.dust[dust].velocity *= 0.1f;
            Main.dust[dust].scale = (float)Main.rand.Next(80, 115) * 0.013f;
            Main.dust[dust].noGravity = true;
			int dust2 = Dust.NewDust(projectilePosition, 0, 0, 54, 0f, 0f, 0, default(Color), 1f);
			Main.dust[dust2].velocity *= 0.4f;
			Main.dust[dust2].scale = (float)Main.rand.Next(80, 115) * 0.013f;
			Main.dust[dust2].noGravity = true;
		}

        public override void Kill(int timeLeft)
        {
            Vector2 center = projectile.Center;
            Main.PlaySound(0, (int)center.X, (int)center.Y, 1, 1f, 0f);
            for (var i = 0; i < 6; i++)
            {
                Vector2 projectilePosition = projectile.position;
                int dust = Dust.NewDust(projectilePosition, 1, 1, dust_num, 0f, 0f, 0, default(Color), 1f);
                Main.dust[dust].velocity *= 1f;
                Main.dust[dust].scale = (float)Main.rand.Next(115, 155) * 0.013f;
                Main.dust[dust].noGravity = true;
                int dust2 = Dust.NewDust(projectilePosition, 1, 1, dust_num2, 0f, 0f, 0, default(Color), 1f);
                Main.dust[dust2].velocity *= 0.2f;
                Main.dust[dust2].scale = (float)Main.rand.Next(115, 155) * 0.013f;
                Main.dust[dust2].noGravity = true;
            }
        }

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
		{
			if (target.type != 488)
			{
				Player obj = Main.player[projectile.owner];
				int num = damage / 20;
				if (num >= 3)
				{
					num = 3;
				}
				if (num <= 0)
				{
					num = 1;
				}
				obj.statLife += num;
				obj.HealEffect(num, true);
			}
		}

		public CrimsonProj()
			
		{
		}
	}
}
