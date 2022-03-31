using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Accessories
{
	public class Flint : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sharp Flint");
			Tooltip.SetDefault("Causes arrows to split into shrapnel on impact");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 0;
			item.rare = 1;
			item.value = 50000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.GetModPlayer<GlobalPlayer>().sharpFlint = true;
		}

		public Flint()
			
		{
		}
	}
}
