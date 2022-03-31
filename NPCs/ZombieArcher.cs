using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.NPCs
{
	public class ZombieArcher : ModNPC
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Zombie Archer");
			Main.npcFrameCount[npc.type] = Main.npcFrameCount[111];
		}

		public override void SetDefaults()
		{
			npc.friendly = false;
			npc.width = 18;
			npc.height = 40;
			npc.aiStyle = 7;
			npc.damage = 18;
			npc.defense = 5;
			npc.lifeMax = 37;
			npc.HitSound = SoundID.NPCHit1;
			npc.DeathSound = SoundID.NPCDeath2;
			npc.knockBackResist = 0.5f;
			npc.aiStyle = 3;
			aiType = 111;
			animationType = 111;
		}

		public override float SpawnChance(NPCSpawnInfo spawnInfo)
		{
			return SpawnCondition.OverworldNightMonster.Chance * 0.33f;
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

		public void HitEffect(int hitDirection, double damage)
		{
			for (int i = 0; i < 12; i++)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, 5, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public override void NPCLoot()
		{
			Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ZombieArcherGore1"), 1f);
			Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ZombieArcherGore2"), 1f);
			Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ZombieArcherGore3"), 1f);
			Gore.NewGore(npc.position, npc.velocity, mod.GetGoreSlot("Gores/ZombieArcherGore4"), 1f);
			aiType = 3;
			Item.NewItem(npc.getRect(), mod.ItemType("Hide"), 1, false, 0, false, false);
			Item.NewItem(npc.getRect(), 71, Main.rand.Next(48, 75), false, 0, false, false);
			Item.NewItem(npc.getRect(), 72, Main.rand.Next(1, 1), false, 0, false, false);
			if (Main.rand.Next(100) >= 94)
			{
				Item.NewItem(npc.getRect(), mod.ItemType("Target"), 1, false, 0, false, false);
			}
			for (int i = 0; i < 12; i++)
			{
				Dust.NewDust(npc.position, npc.width, npc.height, 194, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(npc.position, npc.width, npc.height, 194, 0f, 0f, 0, default(Color), 1f);
				Dust.NewDust(npc.position, npc.width, npc.height, 5, 0f, 0f, 0, default(Color), 1f);
			}
		}

		public ZombieArcher()
			
		{
		}
	}
}
