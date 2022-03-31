using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class MoltenCrossbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Molten Crossbow");
			Tooltip.SetDefault("Wooden arrows are set ablaze\nRight-click to launch a charged hellfire-arrow");
		}

		public override void SetDefaults()
		{
			item.damage = 34;
			item.ranged = true;
			item.shoot = 1;
			item.width = 56;
			item.height = 30;
			item.useTime = 28;
			item.useAnimation = 28;
			item.knockBack = 6f;
			item.value = 22000;
			item.useStyle = 5;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			if (type == 1)
			{
				type = 2;
			}
			if (player.altFunctionUse == 2)
			{
				damage *= 2;
				type = 41;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("WoodenCrossbowProj"), 0, knockback, ((Entity)player).whoAmI, 0f, 0f);
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
				item.useTime = 50;
				item.useAnimation = 50;
				item.UseSound = SoundID.Item102;
			}
			else
			{
				item.crit = 5;
				item.shootSpeed = 10f;
				item.useTime = 28;
				item.knockBack = 6f;
				item.useAnimation = 28;
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
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(175, 15);
			recipe.AddIngredient(173, 10);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public MoltenCrossbow()
			
		{
		}
	}
}
