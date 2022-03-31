using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops
{
	public class SteelHide : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Monster Hide");
			Tooltip.SetDefault("Used to craft powerful gear");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = 2;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "ReinforcedHide", 1);
			recipe.AddIngredient((Mod)null, "SteelBar", 1);
			recipe.AddIngredient(57, 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient((Mod)null, "ReinforcedHide", 1);
			recipe2.AddIngredient((Mod)null, "SteelBar", 1);
			recipe2.AddIngredient(1257, 1);
			recipe2.AddTile(16);
			recipe2.SetResult(mod.ItemType("SteelHide"), 1);
			recipe2.AddRecipe();
		}

		public SteelHide()
			
		{
		}
	}
}
