using Terraria;
using Terraria.ModLoader;

namespace bowmod.Recipes
{
	public class SteelBar2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Bar");
			Tooltip.SetDefault("Can be placed\nForges powerful gear");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 5000;
			item.rare = 2;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 1);
			recipe.AddIngredient(703, 1);
			recipe.AddTile(17);
			recipe.SetResult(mod.ItemType("SteelBar"), 1);
			recipe.AddRecipe();
		}

		public SteelBar2()
			
		{
		}
	}
}
