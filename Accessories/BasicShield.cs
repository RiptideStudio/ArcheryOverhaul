using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	[AutoloadEquip(EquipType.Shield)]
	public class BasicShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Basic War Shield");
			Tooltip.SetDefault("5% decreased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 0;
			item.rare = 1;
			item.value = 10000;
			item.defense = 3;
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
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "Hide", 3);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.AddRecipeGroup("Wood", 25);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public BasicShield()
			
		{
		}
	}
}
