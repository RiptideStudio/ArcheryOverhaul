using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class DungeonBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Surge Bow");
			Tooltip.SetDefault("Turns wooden arrows into piercing oceanic arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 19;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 5;
			item.knockBack = 1f;
			item.value = 50000;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 8f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			if (type == 1)
			{
				type = mod.ProjectileType("SurgeProj");
			}
			return true;
		}
	}
}
