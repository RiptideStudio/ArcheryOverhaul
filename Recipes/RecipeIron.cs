using Terraria;
using Terraria.ModLoader;

namespace bowmod.Recipes
{
	public class RecipeIron : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Bar");
			Tooltip.SetDefault("Can be placed");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 30000;
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(704, 1);
			recipe.AddTile(16);
			recipe.SetResult(22, 1);
			recipe.AddRecipe();
		}

		public RecipeIron()
			
		{
		}
	}
}
