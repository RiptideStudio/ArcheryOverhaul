using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Accessories
{
	public class Target : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Target");
			Tooltip.SetDefault("Arrow speed increased by 12%\nMakes arrows more accurate");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.rare = 1;
			item.value = 30001;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.GetModPlayer<GlobalPlayer>().target = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "Hide", 5);
			recipe.AddRecipeGroup("Wood", 15);
			recipe.AddTile(18);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
