using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	[AutoloadEquip(EquipType.Shield)]
	public class HunterShield2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hunter's Shield");
			Tooltip.SetDefault("7% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 0;
			item.rare = 3;
			item.value = 10000;
			item.defense = 6;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.moveSpeed += 0.07f;
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
			recipe.AddIngredient((Mod)null, "ReinforcedShield", 1);
			recipe.AddIngredient((Mod)null, "SteelHide", 3);
			recipe.AddIngredient(1257, 10);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public HunterShield2()
			
		{
		}
	}
}
