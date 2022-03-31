using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Recipes
{
	public class Leather : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Leather"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("5 Rotten chunks? Nope!");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.RottenChunk, 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(ItemID.Leather, 1);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(ItemID.Vertebrae, 2);
			recipe2.AddTile(TileID.Anvils);
			recipe2.SetResult(ItemID.Leather, 1);
			recipe2.AddRecipe();
		}
	}
}