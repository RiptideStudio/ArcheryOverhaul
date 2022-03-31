using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class ArcherCloak : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hunter's Cloak");
			Tooltip.SetDefault("5% Increased ranged damage and critical strike chance\n20% Chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 3;
			item.defense = 7;
		}

		public static void UpdateArmorSet(Player player)
		{
			player.rangedDamage += 20f;
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
			recipe.AddIngredient(152, 1);
			recipe.AddIngredient(175, 20);
			recipe.AddIngredient((Mod)null, "SteelHide", 5);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public ArcherCloak()
			
		{
		}
	}
}
