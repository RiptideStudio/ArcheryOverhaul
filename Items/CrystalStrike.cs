using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class CrystalStrike : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Strike");
			Tooltip.SetDefault("Launches a crystal strike at your enemy");
		}

		public override void SetDefaults()
		{
			item.damage = 26;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 33;
			item.useAnimation = 33;
			item.useStyle = 5;
			item.knockBack = 2f;
			item.value = 50000;
			item.rare = 4;
			item.noMelee = true;
			item.UseSound = SoundID.Item101;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 11f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX * 2f, speedY * 2f, 494, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			Projectile.NewProjectile(position.X, position.Y, speedX * 2f, speedY * 2f, 521, damage / 2, knockback, ((Entity)player).whoAmI, 0f, 0f);
			int num = 1;
			float num2 = MathHelper.ToRadians(15f);
			float num3 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num4 = Math.Atan2(speedX, speedY) - (double)(num2 / 2f);
			double num5 = num2 / (float)num;
			for (int i = 0; i < num; i++)
			{
				double num6 = num4 + num5 * (double)i;
				Projectile.NewProjectile(position.X, position.Y, num3 * (float)Math.Sin(num6), num3 * (float)Math.Cos(num6), type, damage / 2, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			int num7 = 1;
			float num8 = MathHelper.ToRadians(-15f);
			float num9 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num10 = Math.Atan2(speedX, speedY) - (double)(num8 / 2f);
			double num11 = num8 / (float)num7;
			for (int j = 0; j < num; j++)
			{
				double num12 = num10 + num11 * (double)j;
				Projectile.NewProjectile(position.X, position.Y, num9 * (float)Math.Sin(num12), num9 * (float)Math.Cos(num12), type, damage / 2, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(502, 20);
			recipe.AddIngredient((Mod)null, "MysticShard", 3);
			recipe.AddIngredient(520, 5);
			recipe.AddIngredient((Mod)null, "MysticString", 1);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public CrystalStrike()
			
		{
		}
	}
}
