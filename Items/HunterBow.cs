using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class HunterBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Robin's Longbow");
			Tooltip.SetDefault("'You eel in snake's clothing!'");
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.knockBack = 1f;
			item.value = 10000;
			item.rare = 2;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 6f;
			item.useAmmo = AmmoID.Arrow;
		}

		public HunterBow()
			
		{
		}
	}
}
