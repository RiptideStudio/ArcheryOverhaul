using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class CloudBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lightning Strike");
			Tooltip.SetDefault("Shoots electric arrows\nOccasionally shoots an electric sphere");
		}

		public override void SetDefaults()
		{
			item.damage = 36;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 3f;
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
			if (Main.rand.Next(2) == 0)
			{
				Main.PlaySound(SoundID.Item92.WithPitchVariance(0.2f), -1, -1);
				Projectile.NewProjectile(position.X, position.Y, speedX * 0.5f, speedY * 0.5f, 443, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("ElectricProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			return false;
		}

		public CloudBow()
			
		{
		}
	}
}
