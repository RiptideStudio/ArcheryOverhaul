using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Accessories
{
	public class SteelTarget : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Reinforced Target");
			Tooltip.SetDefault("7% Increased arrow critical strike chance\nArrow penetration increased by 1\nEffects of Target");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.rare = 2;
			item.value = 50001;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.rangedCrit += 7;
			player.ghostFade = 2f;
			player.GetModPlayer<GlobalPlayer>().target = true;
			player.GetModPlayer<GlobalPlayer>().target2 = true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "Target", 1);
			recipe.AddIngredient((Mod)null, "SteelBar", 5);
			recipe.AddRecipeGroup("Wood", 25);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public SteelTarget()
			
		{
		}
	}
}
