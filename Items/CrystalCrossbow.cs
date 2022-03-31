using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class CrystalCrossbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Crossbow");
			Tooltip.SetDefault("Right-click to launch a charged crystal-arrow");
		}

		public override void SetDefaults()
		{
			item.damage = 45;
			item.ranged = true;
			item.shoot = 1;
			item.width = 56;
			item.height = 30;
			item.useTime = 22;
			item.useAnimation = 22;
			item.knockBack = 6f;
			item.value = 42000;
			item.useStyle = 5;
			item.rare = 4;
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
				type = mod.ProjectileType("CrystalProj");
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

				item.shootSpeed = 19f;
				item.knockBack = 8f;
				item.crit = 10;
				item.useTime = 45;
				item.useAnimation = 45;
				item.UseSound = SoundID.Item102;
			}
			else
			{
				item.crit = 5;
				item.shootSpeed = 11f;

				item.useTime = 22;
				item.knockBack = 7f;
				item.useAnimation = 22;
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
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(502, 15);
			recipe.AddIngredient((Mod)null, "MysticString", 3);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public CrystalCrossbow()
			
		{
		}
	}
}
