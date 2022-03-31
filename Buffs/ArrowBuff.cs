using Terraria;
using Terraria.ModLoader;

namespace bowmod.Buffs
{
	public class ArrowBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Sharpened Arrows");
			Description.SetDefault("Arrow damage increased by 10%");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = false;
		}

		public override void Update(Player player, ref int buffIndex)
		{
			player.arrowDamage += 0.1f;
		}
	}
}
