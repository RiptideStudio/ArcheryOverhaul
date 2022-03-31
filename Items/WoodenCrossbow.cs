using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class WoodenCrossbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Crossbow");
			Tooltip.SetDefault("Right-click to launch a charged arrow");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.ranged = true;
			item.shoot = 1;
			item.width = 56;
			item.height = 30;
			item.useTime = 35;
			item.useAnimation = 35;
			item.knockBack = 3.5f;
			item.value = 100;
			item.useStyle = 5;
			item.rare = 1;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shootSpeed = 8f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.shootSpeed = 12f;
				item.crit = 10;
				item.knockBack = 4f;
				item.useTime = 52;
				item.useAnimation = 52;
				item.UseSound = SoundID.Item102;
			}
			else
			{
				item.crit = 5;
				item.shootSpeed = 8f;
				item.knockBack = 3.5f;
				item.useTime = 35;
				item.useAnimation = 35;
				item.UseSound = SoundID.Item5;
			}
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			if (player.altFunctionUse == 2)
			{
				damage += damage;
				Projectile.NewProjectile(position.X, position.Y, speedX / 2f, speedY / 2f, mod.ProjectileType("WoodenCrossbowProj"), 0, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}

			return true;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(2f, 0f);
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 25);
			recipe.AddIngredient((Mod)null, "String", 2);
			recipe.AddTile(18);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public WoodenCrossbow()
			
		{
		}
	}
}
