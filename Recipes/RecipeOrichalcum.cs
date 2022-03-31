using Terraria;
using Terraria.ModLoader;

namespace bowmod.Recipes
{
	public class RecipeOrichalcum : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Orichalcum Bar");
			Tooltip.SetDefault("Can be placed");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 30000;
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(382, 1);
			recipe.AddTile(134);
			recipe.SetResult(1191, 1);
			recipe.AddRecipe();
		}

		public RecipeOrichalcum()
			
		{
		}
	}
}
