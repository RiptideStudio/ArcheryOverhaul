using Terraria;
using Terraria.ModLoader;

namespace bowmod.Buffs
{
	public class ColdBuff : ModBuff
	{
		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.lifeRegen -= 35;
		}

	}
}
