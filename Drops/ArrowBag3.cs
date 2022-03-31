using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops
{
	public class ArrowBag3 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tier 3 Arrow Pouch");
			Tooltip.SetDefault("Right-click to open\nContains an assortment of strong arrows");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 3;
			item.value = 12000;
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
			int num = Main.rand.Next(3);
			if (num == 0)
			{
				player.QuickSpawnItem(mod.ItemType("GraniteArrow"), Main.rand.Next(30, 40));
			}
			if (num == 1)
			{
				player.QuickSpawnItem(mod.ItemType("MarbleArrow"), Main.rand.Next(30, 40));
			}
			if (num == 2)
			{
				player.QuickSpawnItem(51, Main.rand.Next(25, 35));
			}
			player.QuickSpawnItem(mod.ItemType("Grenade3"), Main.rand.Next(3, 5));
			if (Main.rand.Next(150) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("StrangeQuiver"), 1);
			}
			int num2 = Main.rand.Next(3);
			if (num2 == 1)
			{
				player.QuickSpawnItem(47, Main.rand.Next(20, 35));
			}
			if (num2 == 2)
			{
				player.QuickSpawnItem(mod.ItemType("PoisonArrow"), Main.rand.Next(25, 35));
			}
			base.RightClick(player);
			player.QuickSpawnItem(40, Main.rand.Next(25, 35));
			player.QuickSpawnItem(mod.ItemType("Grenade2"), Main.rand.Next(5, 8));
			if (Main.rand.Next(2) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("ArrowPotion"), Main.rand.Next(1, 1));
			}
		}

		public ArrowBag3()
			
		{
		}
	}
}
