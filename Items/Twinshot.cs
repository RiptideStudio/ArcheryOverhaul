using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class Twinshot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Twinshot");
			Tooltip.SetDefault("Converts wooden arrows into mechanical eyes\nFires an additional cursed flame blast every second shot\nShoots a laser every fifth shot");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(8f, 0f);
		}

		public override void SetDefaults()
		{
			item.damage = 41;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 13;
			item.useAnimation = 13;
			item.useStyle = 5;
			item.knockBack = 4f;
			item.value = 500000;
			item.rare = 7;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 15f;
		}

		int shot = 0;

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			shot += 1;
			if (shot % 5 == 0)
            {
				var proj = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 83, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
				Main.projectile[proj].friendly = true;
				Main.projectile[proj].hostile = false;
				shot = 0;
			}
			if (shot % 2 == 0)
			{
				var proj = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 96, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
				Main.projectile[proj].friendly = true;
				Main.projectile[proj].hostile = false;
			}
			if (type == 1) type = mod.ProjectileType("MechanicalEye");
			return true;
		}


	}
}
