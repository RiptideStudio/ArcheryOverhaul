using Terraria;
using Terraria.ModLoader;

namespace bowmod.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class PixelHat : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pixelated Head");
			Tooltip.SetDefault("'To the Swamplands!'");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1;
			item.vanity = true;
			item.rare = 5;
		}

		public PixelHat()
			
		{
		}
	}
}
