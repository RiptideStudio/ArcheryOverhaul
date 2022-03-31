using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	public class ArrowRock : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Earthen Arrow Stone");
			Tooltip.SetDefault("'One of the four stones of the ancient archers'\nReleases stone arrows when hurt\nMovement speed reduced by 10%");
		}

		public override void SetDefaults()
		{
			item.width = 70;
			item.height = 28;
			item.rare = 3;
			item.value = 100001;
			item.defense = 6;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.ghostFrameCounter = 50;
			player.moveSpeed -= 0.1f;
		}

		public ArrowRock()
			
		{
		}
	}
}
