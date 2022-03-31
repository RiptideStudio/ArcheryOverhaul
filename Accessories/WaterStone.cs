using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	public class WaterStone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dripping Arrow Stone");
			Tooltip.SetDefault("'One of the four stones of the ancient archers'\nReleases oceanic arrows when hurt");
		}

		public override void SetDefaults()
		{
			item.width = 72;
			item.height = 52;
			item.rare = 3;
			item.value = 100011;
			item.defense = 4;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
		}

		public WaterStone()
			
		{
		}
	}
}
