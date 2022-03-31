using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	[AutoloadEquip(EquipType.Shield)]
	public class ReinforcedShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Reinforced War Shield");
			Tooltip.SetDefault("7% decreased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 0;
			item.rare = 2;
			item.value = 10000;
			item.defense = 5;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.moveSpeed -= 0.05f;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "BasicShield", 1);
			recipe.AddIngredient((Mod)null, "ReinforcedHide", 3);
			recipe.AddIngredient(19, 5);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			ModRecipe val2 = new ModRecipe(mod);
			val2.AddIngredient((Mod)null, "BasicShield", 1);
			val2.AddIngredient((Mod)null, "ReinforcedHide", 3);
			val2.AddIngredient(706, 5);
			val2.AddTile(16);
			val2.SetResult(this, 1);
			val2.AddRecipe();
		}

		public ReinforcedShield()
			
		{
		}
	}
}
