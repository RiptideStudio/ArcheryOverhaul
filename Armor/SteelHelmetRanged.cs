using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SteelHelmetRanged : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Mask");
			Tooltip.SetDefault("Ranged damage increased by 5%");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 2;
			item.defense = 3;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Metal Burst has 33% increased speed";
			player.rangedDamage += 0.05f;
			player.GetModPlayer<GlobalPlayer>().burstBuff = true;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			if (body.type == mod.ItemType("SteelChest"))
			{
				return legs.type == mod.ItemType("SteelPants");
			}
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "SteelBar", 10);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public SteelHelmetRanged()
			
		{
		}
	}
}
