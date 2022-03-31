using Terraria;
using Terraria.ModLoader;

namespace bowmod.Recipes
{
	public class SteelBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Bar");
			Tooltip.SetDefault("Can be placed\nForges powerful gear");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 5000;
			item.rare = 2;
		}

		public SteelBar()
			
		{
		}
	}
}
