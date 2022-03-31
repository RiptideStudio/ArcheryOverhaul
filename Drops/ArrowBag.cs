using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops
{
	public class ArrowBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tier 1 Arrow Pouch");
			Tooltip.SetDefault("Right-click to open\nContains an assortment of arrows");
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
			int num = Main.rand.Next(3);
			int num2 = Main.rand.Next(350);
			if (Main.rand.Next(400) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("StrangeBow"), 1);
			}
			if (num2 == 0)
			{
				player.QuickSpawnItem(mod.ItemType("StrangeQuiver"), 1);
			}
			if (num == 0)
			{
				player.QuickSpawnItem(41, Main.rand.Next(10, 20));
			}
			if (num == 1)
			{
				player.QuickSpawnItem(988, Main.rand.Next(10, 20));
			}
			if (num == 2)
			{
				player.QuickSpawnItem(51, Main.rand.Next(10, 20));
			}
			int num3 = Main.rand.Next(3);
			if (num3 == 1)
			{
				player.QuickSpawnItem(47, Main.rand.Next(5, 15));
			}
			if (num3 == 2)
			{
				player.QuickSpawnItem(mod.ItemType("SandArrow"), Main.rand.Next(15, 25));
			}
			base.RightClick(player);
			player.QuickSpawnItem(40, Main.rand.Next(25, 35));
			player.QuickSpawnItem(mod.ItemType("Grenade1"), Main.rand.Next(4, 7));
			if (Main.rand.Next(2) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("ArrowPotion"), Main.rand.Next(1, 1));
			}
		}

		public ArrowBag()
			
		{
		}
	}
}
