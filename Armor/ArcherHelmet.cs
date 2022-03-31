using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class ArcherHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hunter's Hood");
			Tooltip.SetDefault("12% Increased ranged damage\n5% Increased ranged critical strike chance");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 3;
			item.defense = 6;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Increased invincibility length";
			player.rangedDamage += 0.19f;
			player.rangedCrit += 10;
			player.moveSpeed += 0.12f;
			player.ammoBox = true;
			player.longInvince = true;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			if (body.type == mod.ItemType("ArcherCloak"))
			{
				return legs.type == mod.ItemType("ArcherPants");
			}
			return false;
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
			recipe.AddIngredient(151, 1);
			recipe.AddIngredient(175, 10);
			recipe.AddIngredient((Mod)null, "SteelHide", 3);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public ArcherHelmet()
			
		{
		}
	}
}
