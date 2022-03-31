using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops
{
	public class DropBow : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			int num = Main.rand.Next(100);
			if (npc.type == 4)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Eyeshot"), 1, false, 0, false, false);
			}
			//Twings
			if (npc.type == 126)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Twinshot"), 1, false, 0, false, false);
			}
			if (npc.type == 250 && num <= 12)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("CloudBow"), 1, false, 0, false, false);
			}
			if (npc.type == 153 && num <= 7)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("ShellShot"), 1, false, 0, false, false);
			}
			if (npc.type == 243 && num <= 25)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("ColdBow"), 1, false, 0, false, false);
			}
			if (npc.type == 477)
			{
				if (num <= 20 && NPC.downedPlantBoss)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("Eclipse"), 1, false, 0, false, false);
				}
				if (num <= 30)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("BrokenBow"), 1, false, 0, false, false);
				}
			}
			if (npc.type == 238 && num <= 10)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("SpiderBow"), 1, false, 0, false, false);
			}
			if (npc.type == 163 && num <= 10)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("SpiderBow"), 1, false, 0, false, false);
			}
			if (npc.type == 113)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("FleshRepeater"), 1, false, 0, false, false);
			}
			if ((float)num > 96f)
			{
				if (npc.type == 49)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("ArrowRock"), 1, false, 0, false, false);
				}
				if (npc.type == 150)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("ArrowRock"), 1, false, 0, false, false);
				}
				if (npc.type == 482)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("ArrowRock"), 1, false, 0, false, false);
				}
			}
			if ((float)num > 98f)
			{
				if (Main.hardMode)
				{
					if (npc.type == 60)
					{
						Item.NewItem(npc.getRect(), mod.ItemType("FireArrowStone"), 1, false, 0, false, false);
					}
					if (npc.type == 59)
					{
						Item.NewItem(npc.getRect(), mod.ItemType("FireArrowStone"), 1, false, 0, false, false);
					}
					if (npc.type == 24)
					{
						Item.NewItem(npc.getRect(), mod.ItemType("FireArrowStone"), 1, false, 0, false, false);
					}
				}
				if (Main.player[Player.FindClosest(npc.position, npc.width, npc.height)].ZoneBeach)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("WaterStone"), 1, false, 0, false, false);
				}
			}
			if ((float)num > 95f && Main.hardMode && npc.type == 48)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("AirStone"), 1, false, 0, false, false);
			}
			if ((float)num > 66f && npc.type == 44)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("ArrowRock"), 1, false, 0, false, false);
			}
			if ((float)num >= 98.5f)
			{
				if (npc.type == 31)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("DungeonBow"), 1, false, 0, false, false);
				}
				if (npc.type == -13)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("DungeonBow"), 1, false, 0, false, false);
				}
				if (npc.type == -14)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("DungeonBow"), 1, false, 0, false, false);
				}
				if (npc.type == 294)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("DungeonBow"), 1, false, 0, false, false);
				}
				if (npc.type == 295)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("DungeonBow"), 1, false, 0, false, false);
				}
				if (npc.type == 296)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("DungeonBow"), 1, false, 0, false, false);
				}
			}
		}

		public DropBow()
			
		{
		}
	}
}
