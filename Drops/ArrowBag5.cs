using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops
{
	public class ArrowBag5 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tier 5 Arrow Pouch");
			Tooltip.SetDefault("Right-click to open\nContains a huge assortment of the best arrows");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 5;
			item.value = 32000;
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
			if (num == 0)
			{
				player.QuickSpawnItem(1341, Main.rand.Next(50, 75));
			}
			if (num == 1)
			{
				player.QuickSpawnItem(516, Main.rand.Next(50, 75));
			}
			if (Main.rand.Next(115) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("StrangeQuiver"), 1);
			}
			int num2 = Main.rand.Next(2);
			if (num2 == 0)
			{
				player.QuickSpawnItem(1334, Main.rand.Next(75, 100));
			}
			if (num2 == 1)
			{
				player.QuickSpawnItem(mod.ItemType("ExplosiveArrow"), Main.rand.Next(75, 100));
			}
			base.RightClick(player);
			player.QuickSpawnItem(40, Main.rand.Next(100, 150));
			player.QuickSpawnItem(mod.ItemType("GraniteArrow"), Main.rand.Next(75, 100));
			player.QuickSpawnItem(1235, Main.rand.Next(25, 75));
			player.QuickSpawnItem(mod.ItemType("Grenade2"), Main.rand.Next(1, 4));
			player.QuickSpawnItem(mod.ItemType("Grenade3"), Main.rand.Next(4, 7));
			if (Main.rand.Next(2) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("ArrowPotion"), Main.rand.Next(1, 1));
			}
		}

		public ArrowBag5()
			
		{
		}
	}
}
