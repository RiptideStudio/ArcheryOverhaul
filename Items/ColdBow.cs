using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class ColdBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Absolute Zero");
			Tooltip.SetDefault("Shoots a spread of frozen arrows\nInflics chill debuff");
		}

		public override void SetDefaults()
		{
			item.damage = 35;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 4f;
			item.value = 100000;
			item.rare = 4;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 12f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			int num = 1;
			float num2 = MathHelper.ToRadians(0f);
			for (int i = 0; i < num; i++)
			{
				Vector2 vector = Utils.RotatedBy(new Vector2(speedX, speedY), (double)MathHelper.Lerp(0f - num2, num2, i / num), default(Vector2));
				Projectile.NewProjectile(position.X, position.Y, vector.X, vector.Y, mod.ProjectileType("ColdProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			int num3 = 1;
			float num4 = MathHelper.ToRadians(10f);
			float num5 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num6 = Math.Atan2(speedX, speedY) - (double)(num4 / 2f);
			double num7 = num4 / (float)num3;
			for (int j = 0; j < num3; j++)
			{
				double num8 = num6 + num7 * (double)j;
				Projectile.NewProjectile(position.X, position.Y, num5 * (float)Math.Sin(num8), num5 * (float)Math.Cos(num8), mod.ProjectileType("ColdProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			int num9 = 1;
			float num10 = MathHelper.ToRadians(-10f);
			float num11 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num12 = Math.Atan2(speedX, speedY) - (double)(num10 / 2f);
			double num13 = num10 / (float)num9;
			for (int k = 0; k < num3; k++)
			{
				double num14 = num12 + num13 * (double)k;
				Projectile.NewProjectile(position.X, position.Y, num11 * (float)Math.Sin(num14), num11 * (float)Math.Cos(num14), mod.ProjectileType("ColdProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			return false;
		}

		public ColdBow()
			
		{
		}
	}
}
