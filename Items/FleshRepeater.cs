using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class FleshRepeater : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Fleshy Repeater");
			Tooltip.SetDefault("'It's kinda squishy...\nShoots a burst of arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 26;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 5;
			item.useAnimation = 15;
			item.reuseDelay = 16;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 100000;
			item.rare = 4;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool ConsumeAmmo(Player player)
		{
			Main.PlaySound(SoundID.Item5, -1, -1);
			return player.itemAnimation >= item.useAnimation - 2;
		}

		public FleshRepeater()
			
		{
		}
	}
}
