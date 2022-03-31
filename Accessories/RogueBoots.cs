using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	public class RogueBoots : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rogue's Boots");
			Tooltip.SetDefault("Allows the wearer to run insanely fast");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 0;
			item.rare = 2;
			item.value = 30000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.accRunSpeed = 7f;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(54, 1);
			recipe.AddIngredient(320, 5);
			recipe.AddIngredient(225, 5);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public RogueBoots()
			
		{
		}
	}
}
