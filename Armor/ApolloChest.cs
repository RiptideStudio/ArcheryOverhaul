using Terraria;
using Terraria.ModLoader;

namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class ApolloChest : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Apollo's Breastplate");
			Tooltip.SetDefault("5% Increased ranged damage and critical strike chance\n20% Chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 50000;
			item.rare = 8;
			item.defense = 15;
		}

		public static void UpdateArmorSet(Player player)
		{
			player.rangedDamage += 20f;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "DwarfAlloy", 24);
			recipe.AddIngredient((Mod)null, "DaoShard", 3);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public ApolloChest()
			
		{
		}
	}
}
