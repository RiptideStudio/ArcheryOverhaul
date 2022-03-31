using Terraria;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class MysticString : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mystic String");
			Tooltip.SetDefault("'Bound by light magic'");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 10000;
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "String", 1);
			recipe.AddIngredient(520, 1);
			recipe.AddTile(86);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public MysticString()
			
		{
		}
	}
}
