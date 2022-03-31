using Terraria;
using Terraria.ModLoader;

namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class PixelChest : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pixelated Shirt");
			Tooltip.SetDefault("'To the Craglands!'");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.rare = 5;
			item.vanity = true;
		}

		public PixelChest()
			
		{
		}
	}
}
