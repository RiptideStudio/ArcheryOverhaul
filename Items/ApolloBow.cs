using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class ApolloBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Apollo's Volley");
			Tooltip.SetDefault("Launches a volley of magma");
		}

		public override void SetDefaults()
		{
			item.damage = 45;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 42;
			item.useAnimation = 42;
			item.useStyle = 5;
			item.knockBack = 4.5f;
			item.value = 500000;
			item.rare = 7;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 9f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 425, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			Projectile.NewProjectile(position.X, position.Y, speedX * 2f, speedY * 2f, 668, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 85, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			int num = 5;
			float num2 = MathHelper.ToRadians(13f);
			float num3 = (float)Math.Sqrt(speedX * speedX + speedY * speedY) * 2f;
			double num4 = Math.Atan2(speedX, speedY) - (double)(num2 / 2f);
			double num5 = num2 / (float)num;
			for (int i = 0; i < num; i++)
			{
				double num6 = num4 + num5 * (double)i;
				Projectile.NewProjectile(position.X, position.Y, num3 * (float)Math.Sin(num6), num3 * (float)Math.Cos(num6), 2, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "Armageddon", 1);
			recipe.AddIngredient((Mod)null, "DwarfAlloy", 18);
			recipe.AddIngredient((Mod)null, "DaoShard", 1);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public ApolloBow()
			
		{
		}
	}
}
