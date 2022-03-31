using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.NPCs
{
	[AutoloadHead]
	public class Archer : ModNPC
	{
		public override bool Autoload(ref string name)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			name = "Archer";
			return mod.Properties.Autoload;
		}

		public override void SetDefaults()
		{
			npc.townNPC = true;
			npc.friendly = true;
			npc.width = 18;
			npc.height = 46;
			npc.aiStyle = 7;
			npc.defense = 25;
			npc.lifeMax = 250;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath1;
			npc.knockBackResist = 0.5f;
			Main.npcFrameCount[npc.type] = 25;
			NPCID.Sets.ExtraFramesCount[npc.type] = 0;
			NPCID.Sets.AttackFrameCount[npc.type] = 1;
			NPCID.Sets.DangerDetectRange[npc.type] = 450;
			NPCID.Sets.AttackType[npc.type] = 1;
			NPCID.Sets.AttackTime[npc.type] = 30;
			NPCID.Sets.AttackAverageChance[npc.type] = 10;
			NPCID.Sets.HatOffsetY[npc.type] = 4;
			animationType = 22;
		}

		public override bool CanTownNPCSpawn(int numTownNPCs, int money)
		{
			for (int i = 0; i < 255; i++)
			{
				Player recipe = Main.player[i];
				if (((Entity)recipe).active)
				{
					Item[] inventory = recipe.inventory;
					int num = 0;
					if (num < inventory.Length)
					{
						_ = inventory[num].type;
						_ = 40;
						return true;
					}
				}
			}
			return false;
		}

		public override string TownNPCName()
		{
			switch (WorldGen.genRand.Next(4))
			{
			case 0:
				return "Orion";
			case 1:
				return "Pierre";
			default:
				return "Robin";
			}
		}

		public override void SetChatButtons(ref string button, ref string button2)
		{
			button = "Shop";
		}

		public override void OnChatButtonClicked(bool firstButton, ref bool openShop)
		{
			if (firstButton)
			{
				openShop = true;
			}
		}

		public override void SetupShop(Chest shop, ref int nextSlot)
		{
			shop.item[nextSlot].SetDefaults(mod.ItemType("HunterBow"), false);
			nextSlot++;
			if (!Main.dayTime)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("ArcherCrossbow"), false);
				nextSlot++;
			}
			shop.item[nextSlot].SetDefaults(303, false);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Grenade1"), false);
			nextSlot++;
			if (NPC.downedBoss1)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("Grenade2"), false);
				nextSlot++;
			}
			if (NPC.downedBoss2)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("Grenade3"), false);
				nextSlot++;
			}
			shop.item[nextSlot].SetDefaults(mod.ItemType("ArrowBag"), false);
			nextSlot++;
			if (NPC.downedBoss1)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("ArrowBag2"), false);
				nextSlot++;
			}
			if (NPC.downedBoss2)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("ArrowBag3"), false);
				nextSlot++;
			}
			if (NPC.downedBoss3)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("ArrowBag4"), false);
				nextSlot++;
			}
			if (NPC.downedMechBossAny)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("ArrowBag5"), false);
				nextSlot++;
			}
			shop.item[nextSlot].SetDefaults(mod.ItemType("ArrowCarver"), false);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(mod.ItemType("Flint"), false);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(40, false);
			nextSlot++;
			shop.item[nextSlot].SetDefaults(41, false);
			nextSlot++;
			if (NPC.downedSlimeKing)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("GelArrow"), false);
				nextSlot++;
			}
			if (NPC.downedBoss1)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("SandArrow"), false);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(988, false);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("SteelArrow"), false);
				nextSlot++;
			}
			if (NPC.downedBoss2)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("GraniteArrow"), false);
				nextSlot++;
			}
			if (NPC.downedBoss3)
			{
				shop.item[nextSlot].SetDefaults(265, false);
				nextSlot++;
			}
			if (Main.hardMode)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("ExplosiveArrow"), false);
				nextSlot++;
				shop.item[nextSlot].SetDefaults(mod.ItemType("PearlArrow"), false);
				nextSlot++;
			}
			if (NPC.downedMechBossAny)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("CrystalArrow"), false);
				nextSlot++;
			}
			if (NPC.downedPlantBoss)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("AlloyArrow"), false);
				nextSlot++;
			}
		}

		public override string GetChat()
		{
			NPC.FindFirstNPC(22);
			switch (Main.rand.Next(5))
			{
			case 0:
				return "If you're a swordsman, you can see yourself out.";
			case 1:
				return "Many travel countless miles across the globe just to find an archery master. Me? Well, I picked up the scent of your money.";
			case 2:
				return "If you accidentally shoot yourself in the face, don't come running to me.";
			case 3:
				return "If you ever need to get rid of a vampire or go roleplaying, I'd recommend my crossbows.";
			case 4:
				if (!Main.dayTime)
				{
					return "Psst! You! I've got something special on sale tonight. So get your gold and give it to me!";
				}
				return "Come back later tonight. I'll have something special on sale.";
			default:
				return "Ah, a fellow bowslinger! I'd be happy to sell you some of my arrows!";
			}
		}

		public override void TownNPCAttackStrength(ref int damage, ref float knockback)
		{
			damage = 15;
			knockback = 2f;
		}

		public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
		{
			cooldown = 5;
			randExtraCooldown = 10;
		}

		public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
		{
			projType = 1;
			attackDelay = 1;
		}

		public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
		{
			multiplier = 7f;
		}

		public override void NPCLoot()
		{
			Item.NewItem(npc.getRect(), mod.ItemType("HunterBow"), 1, false, 0, false, false);
		}

		public Archer()
			
		{
		}
	}
}
