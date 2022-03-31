using Terraria;
using Terraria.ModLoader;

namespace bowmod.Recipes
{
	public class RecipeAnklet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Anklet of the Wind");
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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(331, 12);
			recipe.AddIngredient(210, 1);
			recipe.AddIngredient((Mod)null, "Hide", 5);
			recipe.AddTile(16);
			recipe.SetResult(212, 1);
			recipe.AddRecipe();
		}

		public RecipeAnklet()
			
		{
		}
	}
}
