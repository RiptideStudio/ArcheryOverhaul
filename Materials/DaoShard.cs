using Terraria;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class DaoShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tao Crystal");
			Tooltip.SetDefault("'The dark and light live in equilibrium'");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 30000;
			item.rare = 4;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "MysticShard", 1);
			recipe.AddIngredient((Mod)null, "DemonicShard", 1);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public DaoShard()
			
		{
		}
	}
}
