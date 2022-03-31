using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SplitArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Split Arrow");
			Tooltip.SetDefault("Splits into 2 smaller arrows on impact");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 2f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("SplitProj");
			item.shootSpeed = 5f;
			item.ammo = AmmoID.Arrow;
		}

		public SplitArrow()
			
		{
		}
	}
}
