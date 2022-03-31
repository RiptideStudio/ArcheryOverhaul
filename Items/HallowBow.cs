using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class HallowBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Sight");
			Tooltip.SetDefault("Launches a hallowed strike at your enemy");
		}

		public override void SetDefaults()
		{
			item.damage = 50;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 4f;
			item.value = 300000;
			item.rare = 5;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 12f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("HallowStrike"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			int num = 1;
			float num2 = MathHelper.ToRadians(10f);
			float num3 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num4 = Math.Atan2(speedX, speedY) - (double)(num2 / 2f);
			double num5 = num2 / (float)num;
			for (int i = 0; i < num; i++)
			{
				double num6 = num4 + num5 * (double)i;
				Projectile.NewProjectile(position.X, position.Y, num3 * (float)Math.Sin(num6), num3 * (float)Math.Cos(num6), 156, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
				Projectile.NewProjectile(position.X, position.Y, num3 * (float)Math.Sin(num6), num3 * (float)Math.Cos(num6), 45, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			int num7 = 1;
			float num8 = MathHelper.ToRadians(-10f);
			float num9 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num10 = Math.Atan2(speedX, speedY) - (double)(num8 / 2f);
			double num11 = num8 / (float)num7;
			for (int j = 0; j < num; j++)
			{
				double num12 = num10 + num11 * (double)j;
				Projectile.NewProjectile(position.X, position.Y, num9 * (float)Math.Sin(num12), num9 * (float)Math.Cos(num12), 156, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
				Projectile.NewProjectile(position.X, position.Y, num9 * (float)Math.Sin(num12), num3 * (float)Math.Cos(num12), 45, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "PalladiumBow", 1);
			recipe.AddIngredient((Mod)null, "OricalcumBow", 1);
			recipe.AddIngredient((Mod)null, "TitaniumBow", 1);
			recipe.AddIngredient(1225, 10);
			recipe.AddIngredient(548, 5);
			recipe.AddIngredient(549, 5);
			recipe.AddIngredient(547, 5);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public HallowBow()
			
		{
		}
	}
}
