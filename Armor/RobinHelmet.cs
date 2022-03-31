using Terraria;
using Terraria.ModLoader;

namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class RobinHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Robin's Hood");
			Tooltip.SetDefault("5% Increased ranged damage");
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
			player.setBonus = "20% Chance to not consume arrows\nPermanent Night Vision buff";
			player.ammoBox = true;
			player.nightVision = true;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			if (body.type == mod.ItemType("RobinTunic"))
			{
				return legs.type == mod.ItemType("RobinPants");
			}
			return false;
		}

		public override void UpdateEquip(Player player)
		{
			player.rangedDamage += 0.05f;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("IronBar", 3);
			recipe.AddIngredient(225, 2);
			recipe.AddIngredient((Mod)null, "SteelHide", 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public RobinHelmet()
			
		{
		}
	}
}
