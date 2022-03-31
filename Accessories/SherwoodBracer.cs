using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Accessories
{
	[AutoloadEquip(EquipType.Back)]
	public class SherwoodBracer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sherwood Bracer");
			Tooltip.SetDefault("'Left by the Hooded Man'\n15% Increased ranged damage\nIncreased arrow drop chance");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.rare = 3;
			item.value = 50000;
			item.defense = 3;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.rangedDamage += 0.15f;
			player.ghostFade = 1f;
			player.GetModPlayer<GlobalPlayer>().target = true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "ArcherEmblem", 1);
			recipe.AddIngredient((Mod)null, "Hide", 10);
			recipe.AddIngredient((Mod)null, "SteelBar", 5);
			recipe.AddIngredient(177, 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public SherwoodBracer()
			
		{
		}
	}
}
