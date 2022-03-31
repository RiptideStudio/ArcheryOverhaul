using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops
{
	public class ArrowBag2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tier 2 Arrow Pouch");
			Tooltip.SetDefault("Right-click to open\nContains an assortment of good arrows");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 2;
			item.value = 8000;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			if (Main.rand.Next(400) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("StrangeBow"), 1);
			}
			int num = Main.rand.Next(3);
			if (num == 0)
			{
				player.QuickSpawnItem(mod.ItemType("MarbleArrow"), Main.rand.Next(25, 35));
			}
			if (num == 1)
			{
				player.QuickSpawnItem(988, Main.rand.Next(25, 35));
			}
			if (num == 2)
			{
				player.QuickSpawnItem(51, Main.rand.Next(15, 25));
			}
			if (Main.rand.Next(165) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("StrangeQuiver"), 1);
			}
			int num2 = Main.rand.Next(3);
			if (num2 == 1)
			{
				player.QuickSpawnItem(47, Main.rand.Next(15, 25));
			}
			if (num2 == 2)
			{
				player.QuickSpawnItem(mod.ItemType("SandArrow"), Main.rand.Next(25, 35));
			}
			base.RightClick(player);
			player.QuickSpawnItem(40, Main.rand.Next(35, 50));
			player.QuickSpawnItem(mod.ItemType("Grenade2"), Main.rand.Next(3, 6));
			if (Main.rand.Next(2) == 0)
			{
				player.QuickSpawnItem(mod.ItemType("ArrowPotion"), Main.rand.Next(1, 1));
			}
		}

		public ArrowBag2()
			
		{
		}
	}
}
