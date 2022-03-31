using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops
{
	public class StarterBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Starter Bag");
			Tooltip.SetDefault("Right-click to open\nContains an assortment of archery goods");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 1;
			item.value = 4000;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			base.RightClick(player);
			player.QuickSpawnItem(40, 150);
			player.QuickSpawnItem(mod.ItemType("ArrowBag"), 5);
			player.QuickSpawnItem(mod.ItemType("String"), 1);
			player.QuickSpawnItem(150, 25);
			player.QuickSpawnItem(3504, 1);
		}

		public StarterBag()
			
		{
		}
	}
}
