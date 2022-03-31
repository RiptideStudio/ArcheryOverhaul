using Terraria;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class DemonicShard : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Corrupted Shard");
			Tooltip.SetDefault("'Used to forge weapons of blight'");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 30000;
			item.rare = 3;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(502, 1);
			recipe.AddIngredient(521, 1);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public DemonicShard()
			
		{
		}
	}
}
