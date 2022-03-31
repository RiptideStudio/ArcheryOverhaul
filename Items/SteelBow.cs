using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class SteelBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Bow");
			Tooltip.SetDefault("Converts wooden arrows into steel arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = 5;
			item.knockBack = 3.5f;
			item.value = 20000;
			item.rare = 2;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 7.25f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			if (type == 1)
			{
				type = mod.ProjectileType("SteelArrowProj");
			}
			return true;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(8f, 0f);
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "SteelBar", 12);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public SteelBow()
			
		{
		}
	}
}
