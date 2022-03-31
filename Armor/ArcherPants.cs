using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class ArcherPants : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hunter's Greaves");
			Tooltip.SetDefault("12% Increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 3;
			item.defense = 7;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.rangedDamage += 10f;
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
			recipe.AddIngredient(153, 1);
			recipe.AddIngredient(175, 15);
			recipe.AddIngredient((Mod)null, "SteelHide", 4);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public ArcherPants()
			
		{
		}
	}
}
