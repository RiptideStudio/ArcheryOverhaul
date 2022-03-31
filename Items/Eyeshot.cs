using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class Eyeshot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eyeshot");
			Tooltip.SetDefault("Turns wooden arrows into high-velocity mini eyes of Cthulu");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(8f, 0f);
		}

		public override void SetDefaults()
		{
			item.damage = 24;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 5;
			item.knockBack = 4f;
			item.value = 40000;
			item.rare = 2;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 12f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			if (type == 1)
			{
				type = mod.ProjectileType("EyeballProj");
			}
			return true;
		}


	}
}
