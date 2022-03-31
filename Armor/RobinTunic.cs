using Terraria;
using Terraria.ModLoader;

namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class RobinTunic : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Robin's Tunic");
			Tooltip.SetDefault("5% Increased ranged critical strike chance\n3% Increased ranged damage");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 2;
			item.defense = 6;
		}

		public static void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.03f;
			player.rangedCrit += 5;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 7);
			recipe.AddIngredient(225, 5);
			recipe.AddIngredient((Mod)null, "SteelHide", 5);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public RobinTunic()
			
		{
		}
	}
}
