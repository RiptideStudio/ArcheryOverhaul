using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	[AutoloadEquip(EquipType.Back)]
	public class ReinforcedQuiver : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sturdy Quiver");
			Tooltip.SetDefault("8% Increased Arrow Damage\n20% Chance not to consume arrows");
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

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.rangedDamage += 0.08f;
			player.ammoBox = true;
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
			recipe.AddIngredient((Mod)null, "Quiver", 1);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.AddIngredient((Mod)null, "ReinforcedHide", 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public ReinforcedQuiver()
			
		{
		}
	}
}
