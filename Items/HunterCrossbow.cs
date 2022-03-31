using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class HunterCrossbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Arbalest");
			Tooltip.SetDefault("Right-click to launch a charged arrow");
		}

		public override void SetDefaults()
		{
			item.damage = 27;
			item.ranged = true;
			item.shoot = 1;
			item.width = 56;
			item.height = 30;
			item.useTime = 30;
			item.useAnimation = 30;
			item.knockBack = 6f;
			item.value = 2200;
			item.useStyle = 5;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shootSpeed = 11f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			if (player.altFunctionUse == 2)
			{
				damage *= 2;
				Projectile.NewProjectile(position.X, position.Y, speedX / 2f, speedY / 2f, mod.ProjectileType("WoodenCrossbowProj"), 0, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}

			return true;
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.shootSpeed = 18f;
				item.knockBack = 7f;
				item.crit = 10;
				item.useTime = 45;
				item.useAnimation = 45;
				item.UseSound = SoundID.Item102;
			}
			else
			{
				item.crit = 5;
				item.shootSpeed = 11f;
				item.useTime = 30;
				item.knockBack = 6f;
				item.useAnimation = 30;
				item.UseSound = SoundID.Item5;
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
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "SturdyCrossbow", 1);
			recipe.AddIngredient(57, 12);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 3);
			recipe.AddIngredient(86, 4);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			ModRecipe val2 = new ModRecipe(mod);
			val2.AddIngredient((Mod)null, "SturdyCrossbow", 1);
			val2.AddIngredient(1257, 12);
			val2.AddIngredient((Mod)null, "ReinforcedString", 3);
			val2.AddIngredient(1329, 4);
			val2.AddTile(16);
			val2.SetResult(this, 1);
			val2.AddRecipe();
		}

		public HunterCrossbow()
			
		{
		}
	}
}
