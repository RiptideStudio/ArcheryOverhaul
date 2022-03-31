using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	public class AirStone : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Aerial Arrow Stone");
			Tooltip.SetDefault("'One of the four stones of the ancient archers'\nMobility is greatly improved\nReleases eletric arrows when hit");
		}

		public override void SetDefaults()
		{
			item.width = 69;
			item.height = 52;
			item.rare = 5;
			item.value = 200001;
			item.defense = 3;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.moveSpeed += 0.25f;
			player.accRunSpeed = 7.25f;
		}


	}
}
