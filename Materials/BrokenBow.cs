using Terraria;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class BrokenBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Archer Bow");
			Tooltip.SetDefault("Used to make bows");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = 8;
		}

		public BrokenBow()
			
		{
		}
	}
}
