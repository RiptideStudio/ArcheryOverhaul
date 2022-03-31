using Terraria;
using Terraria.ModLoader;

namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class SteelChest : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Chestplate");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 2;
			item.defense = 5;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "SteelBar", 20);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public SteelChest()
			
		{
		}
	}
}
