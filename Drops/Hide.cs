using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops
{
	public class Hide : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Monster Hide");
			Tooltip.SetDefault("Used to craft gear");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 100;
			item.rare = 1;
		}

		public Hide()
			
		{
		}
	}
}
