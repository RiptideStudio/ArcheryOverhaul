using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using System.Diagnostics;


namespace bowmod.Projectiles
{
    public class ExplosionLarge : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Purple Arrow");
            ProjectileID.Sets.TrailCacheLength[projectile.type] = 4;
            ProjectileID.Sets.TrailingMode[projectile.type] = 0;
            Main.projFrames[projectile.type] = 8;
        }

        float force = 1;

        public override void SetDefaults()
        {
            
            projectile.width = 4;
            projectile.arrow = true;
            projectile.height = 4;
            projectile.aiStyle = 612;
            projectile.friendly = true;
            projectile.hostile = false;
            projectile.magic = true;
            projectile.penetrate = 3751057;
            projectile.light = 0f;
            projectile.ignoreWater = true;
            
            projectile.extraUpdates = 1;

            projectile.width = 36;
            projectile.height = 36;
            projectile.timeLeft = 75;
            projectile.tileCollide = false;
        }
        public override void AI()
        {
            projectile.alpha += 4;
            if (++projectile.frameCounter >= 7)
            {
                projectile.frameCounter = 0;
                if (++projectile.frame > 12)
                {
                    projectile.frame = 0;
                }
            }
            projectile.velocity.X = 0;
            projectile.velocity.Y = 0;
            force -= 0.01f;
            projectile.position.Y -= force;


        }
        public override bool OnTileCollide(Vector2 oldVelocity)
        {
            return true;
        }
        }
}


