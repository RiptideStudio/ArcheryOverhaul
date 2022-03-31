using Terraria;
using Terraria.ModLoader;

namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class SteelHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Helmet");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 2;
			item.defense = 6;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Defense increased by 5";
			player.statDefense += 5;
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
			recipe.AddIngredient((Mod)null, "SteelBar", 12);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public SteelHelmet()
			
		{
		}
	}
}
