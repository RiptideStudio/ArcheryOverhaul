using Terraria;
using Terraria.ModLoader;

namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class PixelPants : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pixelated Pants");
			Tooltip.SetDefault("'To the Ashlands!'");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 5;
			item.vanity = true;
		}

		public PixelPants()
			
		{
		}
	}
}
