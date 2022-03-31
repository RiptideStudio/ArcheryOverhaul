using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class ArcherCrossbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hunter's Crossbow");
			Tooltip.SetDefault("Right-click to launch a volley of charged arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.ranged = true;
			item.shoot = 1;
			item.width = 56;
			item.height = 30;
			item.useTime = 25;
			item.useAnimation = 25;
			item.knockBack = 5f;
			item.value = 225000;
			item.useStyle = 5;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shootSpeed = 9f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			if (player.altFunctionUse == 2)
			{
				damage *= 2;
				int num = 1 + Main.rand.Next(2);
				for (int i = 0; i < num; i++)
				{
					Vector2 vector = Utils.RotatedByRandom(new Vector2(speedX, speedY), (double)MathHelper.ToRadians(20f));
					Projectile.NewProjectile(position.X, position.Y, vector.X, vector.Y, type, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
				}
				if (type == 14)
				{
					type = mod.ProjectileType("DragonsBreath");
				}
				Vector2 vector2 = Vector2.Normalize(new Vector2(speedX, speedY)) * 25f;
				if (Collision.CanHit(position, 0, 0, position + vector2, 0, 0))
				{
					position += vector2;
				}
				Projectile.NewProjectile(position.X, position.Y, speedX / 2f, speedY / 2f, mod.ProjectileType("WoodenCrossbowProj"), 0, knockback, ((Entity)player).whoAmI, 0f, 0f);
				Projectile.NewProjectile(position.X, position.Y, speedX / 2f, speedY / 2f, mod.ProjectileType("WoodenCrossbowProj"), 0, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}

			return true;
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{
				item.shootSpeed = 16f;
				item.crit = 10;
				item.useTime = 45;
				item.knockBack = 6f;
				item.useAnimation = 45;
				item.UseSound = SoundID.Item102;
			}
			else
			{
				item.crit = 5;
				item.shootSpeed = 9f;
				item.knockBack = 5f;
				item.useTime = 25;
				item.useAnimation = 25;
				item.UseSound = SoundID.Item5;
			}
			return true;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(2f, 0f);
		}

		public ArcherCrossbow()
			
		{
		}
	}
}
