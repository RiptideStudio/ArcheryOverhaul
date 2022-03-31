using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	public class FireArrowStone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flaming Arrow Stone");
			Tooltip.SetDefault("'One of the four stones of the ancient archers'\nReleases flaming arrows when hurt");
		}

		public override void SetDefaults()
		{
			item.width = 71;
			item.height = 52;
			item.rare = 5;
			item.value = 300011;
			item.defense = 2;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
		}

		public FireArrowStone()
			
		{
		}
	}
}
