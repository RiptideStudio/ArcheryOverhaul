using Terraria;
using Terraria.ModLoader;

namespace bowmod.Buffs
{
	public class ApolloMinionBuff : ModBuff
	{
		public override void SetDefaults()
		{
			DisplayName.SetDefault("Friendly Arrow");
			Description.SetDefault("A friendly arrow that will fight for you");
			Main.buffNoSave[Type] = true;
			Main.buffNoTimeDisplay[Type] = true;
		}
	}
}
