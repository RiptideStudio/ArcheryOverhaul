using Terraria;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class String : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("String");
			Tooltip.SetDefault("Used to make bows");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 500;
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(150, 3);
			recipe.AddTile(86);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public String()
			
		{
		}
	}
}
