using Terraria;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class DwarfAlloy : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dwarf-Star Alloy");
			Tooltip.SetDefault("'Holds the power of the Sun'");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 100000;
			item.rare = 6;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0043: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(117, 2);
			recipe.AddIngredient(547, 1);
			recipe.AddIngredient(548, 1);
			recipe.AddIngredient(549, 1);
			recipe.AddTile(134);
			recipe.SetResult(this, 2);
			recipe.AddRecipe();
		}

		public DwarfAlloy()
			
		{
		}
	}
}
