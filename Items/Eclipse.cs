using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class Eclipse : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Eclipse");
			Tooltip.SetDefault("'The Sun sets on human life'\nRains destruction from the sky");
		}

		public override void SetDefaults()
		{
			item.damage = 68;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 5;
			item.knockBack = 2f;
			item.value = 600000;
			item.rare = 8;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 15f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("DarkProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			return false;
		}

		public Eclipse()
			
		{
		}
	}
}
