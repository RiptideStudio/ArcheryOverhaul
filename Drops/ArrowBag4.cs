using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops
{
	public class ArrowBag4 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tier 4 Arrow Pouch");
			Tooltip.SetDefault("Right-click to open\nContains an assortment of powerful arrows");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 4;
			item.value = 20000;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			if (Main.rand.Next(350) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("StrangeBow"), 1);
			}
			int num = Main.rand.Next(2);
			player.QuickSpawnItem(mod.ItemType("GraniteArrow"), Main.rand.Next(50, 75));
			if (num == 0)
			{
				player.QuickSpawnItem(mod.ItemType("SkyArrow"), Main.rand.Next(50, 75));
			}
			if (num == 1)
			{
				player.QuickSpawnItem(51, Main.rand.Next(50, 75));
			}
			player.QuickSpawnItem(mod.ItemType("Grenade2"), Main.rand.Next(3, 5));
			if (Main.rand.Next(135) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("StrangeQuiver"), 1);
			}
			int num2 = Main.rand.Next(2);
			if (num2 == 0)
			{
				player.QuickSpawnItem(47, Main.rand.Next(40, 75));
			}
			if (num2 == 1)
			{
				player.QuickSpawnItem(mod.ItemType("ExplosiveArrow"), Main.rand.Next(50, 75));
			}
			base.RightClick(player);
			player.QuickSpawnItem(40, Main.rand.Next(50, 75));
			player.QuickSpawnItem(mod.ItemType("SandArrow"), Main.rand.Next(50, 75));
			player.QuickSpawnItem(mod.ItemType("Grenade3"), Main.rand.Next(3, 6));
			if (Main.rand.Next(2) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("ArrowPotion"), Main.rand.Next(1, 1));
			}
		}

		public ArrowBag4()
			
		{
		}
	}
}
