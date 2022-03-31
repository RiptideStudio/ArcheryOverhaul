using Terraria;
using Terraria.ModLoader;

namespace bowmod.Recipes
{
	public class RecipeBoots : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hermes Boots");
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
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(225, 10);
			recipe.AddIngredient((Mod)null, "Hide", 5);
			recipe.AddIngredient(290, 1);
			recipe.AddTile(16);
			recipe.SetResult(54, 1);
			recipe.AddRecipe();
		}

		public RecipeBoots()
			
		{
		}
	}
}
