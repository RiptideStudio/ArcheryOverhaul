using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class ShellShot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shell Shot");
			Tooltip.SetDefault("'Slow but strong'\nShoots a shell arrow");
		}

		public override void SetDefaults()
		{
			item.damage = 65;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 28;
			item.useAnimation = 28;
			item.useStyle = 5;
			item.knockBack = 8f;
			item.value = 100000;
			item.rare = 4;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 12f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("ShellProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			return false;
		}

		public ShellShot()
			
		{
		}
	}
}
