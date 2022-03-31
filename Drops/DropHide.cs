using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops
{
	public class DropHide : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			int num = Main.rand.Next(1000);
			int num2 = 985;
			int num3 = 980;
			bool drop = false;

			if (!drop)
            {
				if (num >= num2 && !NPC.downedBoss1)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("ArrowBag"), 1, false, 0, false, false);
					drop = true;
				}
				if (num >= num2 && NPC.downedBoss1 && !NPC.downedBoss2)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("ArrowBag2"), 1, false, 0, false, false);
					drop = true;
				}
				if (num >= num2 && NPC.downedBoss2 && !NPC.downedBoss3)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("ArrowBag3"), 1, false, 0, false, false);
					drop = true;
				}
				if (num >= num2 && NPC.downedBoss3 && !NPC.downedMechBossAny)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("ArrowBag4"), 1, false, 0, false, false);
					drop = true;
				}
				if (num >= num2 && NPC.downedMechBossAny)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("ArrowBag5"), 1, false, 0, false, false);
					drop = true;
				}
			}
			
			Player player = Main.player[Player.FindClosest(npc.position, npc.width, npc.height)];
			_ = player.Center.X / 16f;
			float num4 = player.Center.Y / 16f;
			_ = Main.worldSurface;
			_ = Main.hardMode;
			if ((double)num4 < Main.worldSurface && player.ZoneSnow && num >= num3)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("IceBag"), 1, false, 0, false, false);
			}
			if ((double)num4 < Main.worldSurface && player.ZoneJungle && num >= num3)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			int num5 = 920;
			int num6 = Main.rand.Next(3);
			if (npc.type == 147 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("IceBag"), 1, false, 0, false, false);
			}
			if (npc.type == 184 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("IceBag"), 1, false, 0, false, false);
			}
			if (npc.type == 167 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("IceBag"), 1, false, 0, false, false);
			}
			if (npc.type == 150 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("IceBag"), 1, false, 0, false, false);
			}
			if (npc.type == 431 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("IceBag"), 1, false, 0, false, false);
			}
			if (npc.type == 161 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("IceBag"), 1, false, 0, false, false);
			}
			if (npc.type == 42 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == 231 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -16 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -17 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -56 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -57 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == 232 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -58 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -59 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == 233 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -60 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -61 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == 234 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -62 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -63 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == 235 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -64 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -65 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == -10 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == 204 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == 51 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == 56 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == 43 && num >= num5)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("JungleBag"), 1, false, 0, false, false);
			}
			if (npc.type == 3 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 186 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 187 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 188 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 189 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 508 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 509 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 2 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 191 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 190 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 192 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 193 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 194 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 6 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 173 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 181 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 239 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 240 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 140 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 104 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 174 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 94 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 86 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 48 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
			if (npc.type == 61 && num6 == 0)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			}
		}

		public DropHide()
			
		{
		}
	}
}
