using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Accessories
{
	[AutoloadEquip(EquipType.Back)]
	public class MechQuiver : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mechanical Quiver");
			Tooltip.SetDefault("'The quiver of the modern age'\n20% Increased arrow damage\n20% Chance not to consume arrows\n10% increased critical strike chance\nGreatly increased arrow speed\nEffects of Mystic Quiver");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.rare = 8;
			item.value = 300000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.rangedDamage += 0.1f;
			player.rangedCrit += 10;
			player.ammoCost80 = true;
			player.magicQuiver = true;
			player.GetModPlayer<GlobalPlayer>().mysticQuiver = true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "MysticQuiver", 1);
			recipe.AddIngredient(1321, 1);
			recipe.AddIngredient(1248, 1);
			recipe.AddIngredient((Mod)null, "DwarfAlloy", 10);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public MechQuiver()
			
		{
		}
	}
}
