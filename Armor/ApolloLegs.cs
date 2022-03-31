using Terraria;
using Terraria.ModLoader;

namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class ApolloLegs : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Apollo's Leggings");
			Tooltip.SetDefault("15% Increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 50000;
			item.rare = 8;
			item.defense = 12;
		}

		public override void UpdateArmorSet(Player player)
		{
			player.rangedDamage += 10f;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "DwarfAlloy", 20);
			recipe.AddIngredient((Mod)null, "DaoShard", 2);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public ApolloLegs()
			
		{
		}
	}
}
