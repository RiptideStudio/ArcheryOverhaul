using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Accessories
{
	[AutoloadEquip(EquipType.Back)]
	public class StrangeQuiver : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Strange Quiver");
			Tooltip.SetDefault("I wonder what will happen?\nTurns wooden arrows into random arrows\nChanges in hardmode");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.rare = -12;
			item.value = 300000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.ghostFrame = 100;
			player.GetModPlayer<GlobalPlayer>().strangeQuiver = true;
		}

		public StrangeQuiver()
			
		{
		}
	}
}
