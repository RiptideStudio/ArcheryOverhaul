using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops
{
	public class JungleBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Poison Arrow Pouch");
			Tooltip.SetDefault("Right-click to open\nContains an assortment of jungle-themed arrows");
		}

		public override void SetDefaults()
		{
			item.maxStack = 999;
			item.consumable = true;
			item.width = 24;
			item.height = 24;
			item.rare = 2;
			item.value = 4000;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player player)
		{
			if (Main.rand.Next(25) == 0)
			{
					player.QuickSpawnItem(mod.ItemType("JungleShot"), 1);
			}
			int num = Main.rand.Next(3);
			if (num == 1)
			{
				player.QuickSpawnItem(988, Main.rand.Next(10, 20));
			}
			if (num == 2)
			{
				player.QuickSpawnItem(51, Main.rand.Next(10, 20));
			}
			if (Main.rand.Next(3) == 1)
			{
				player.QuickSpawnItem(47, Main.rand.Next(5, 15));
			}
			base.RightClick(player);
			player.QuickSpawnItem(40, Main.rand.Next(15, 25));
			player.QuickSpawnItem(mod.ItemType("PoisonArrow"), Main.rand.Next(25, 50));
			player.QuickSpawnItem(mod.ItemType("PoisonGrenade"), Main.rand.Next(4, 7));
		}

		public JungleBag()
			
		{
		}
	}
}
