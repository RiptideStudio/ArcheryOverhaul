using Terraria;
using Terraria.ModLoader;

namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class ApolloHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Apollo's Mask");
			Tooltip.SetDefault("15% Increased ranged damage\n7% Increased ranged critical strike chance");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 8;
			item.defense = 18;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Permanenent effects of the archery potion";
			player.rangedDamage += 0.2f;
			player.rangedCrit += 15;
			player.moveSpeed += 0.15f;
			player.ammoBox = true;
			player.archery = true;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			if (body.type == mod.ItemType("ApolloChest"))
			{
				return legs.type == mod.ItemType("ApolloLegs");
			}
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "DwarfAlloy", 16);
			recipe.AddIngredient((Mod)null, "DaoShard", 1);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public ApolloHelmet()
			
		{
		}
	}
}
