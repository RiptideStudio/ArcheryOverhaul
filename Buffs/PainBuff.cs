using Terraria;
using Terraria.ModLoader;

namespace bowmod.Buffs
{
	public class PainBuff : ModBuff
	{
		public override void Update(NPC npc, ref int buffIndex)
		{
			npc.lifeRegen -= 20;
		}

	}
}
