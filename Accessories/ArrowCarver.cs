using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	public class ArrowCarver : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arrow Carver");
			Tooltip.SetDefault("5% Increased ranged critical strike chance\n2% Increased arrow damage");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 0;
			item.rare = 1;
			item.value = 30000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.rangedCrit += 5;
			player.rangedDamage += 0.02f;
		}

		public ArrowCarver()
			
		{
		}
	}
}
