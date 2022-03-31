using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	public class Quiver3_3 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hunter's Quiver");
			Tooltip.SetDefault("An Archer's Main Accessory\n8% Increased arrow damage and critical strike chance\n20% Chance not to consume arrows");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 0;
			item.rare = 3;
			item.value = 50000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.rangedDamage += 0.08f;
			player.rangedCrit += 8;
			player.ammoBox = true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "ReinforcedQuiver", 1);
			recipe.AddIngredient(1257, 10);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.AddIngredient((Mod)null, "SteelHide", 5);
			recipe.AddTile(16);
			recipe.SetResult(mod.ItemType("Quiver3"), 1);
			recipe.AddRecipe();
		}

		public Quiver3_3()
			
		{
		}
	}
}
