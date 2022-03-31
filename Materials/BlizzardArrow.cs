using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class BlizzardArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Blizzard Arrow");
			Tooltip.SetDefault("How did this arrow get past screening?\nSummons a mini arrow-blizzard on impact");
		}

		public override void SetDefaults()
		{
			item.damage = 3;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 3f;
			item.value = 50;
			item.rare = 2;
			item.shoot = mod.ProjectileType("BlizzardProj");
			item.shootSpeed = 5f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "SnowArrow", 25);
			recipe.AddIngredient(988, 25);
			recipe.AddIngredient(949, 50);
			recipe.AddTile(16);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}

		public BlizzardArrow()
			
		{
		}
	}
}
