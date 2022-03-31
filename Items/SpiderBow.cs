using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class SpiderBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spider Spitter");
			Tooltip.SetDefault("Punches your enemies with spider webs");
		}

		public override void SetDefaults()
		{
			item.damage = 31;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 2.5f;
			item.value = 100000;
			item.rare = 4;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 8.5f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("SpiderProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			return false;
		}

		public SpiderBow()
			
		{
		}
	}
}
