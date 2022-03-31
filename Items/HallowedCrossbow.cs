using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class HallowedCrossbow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hallowed Crossbow");
			Tooltip.SetDefault("Right-clicking to launch a barrage of hallowed arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 53;
			item.ranged = true;
			item.shoot = 1;
			item.width = 56;
			item.height = 30;
			item.useTime = 24;
			item.useAnimation = 24;
			item.knockBack = 5f;
			item.value = 50000;
			item.useStyle = 5;
			item.rare = 5;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shootSpeed = 11f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool AltFunctionUse(Player player)
		{
			return true;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.altFunctionUse == 2)
			{

				item.shootSpeed = 15f;
				item.crit = 10;
				item.knockBack = 4f;
				item.useTime = 35;
				item.useAnimation = 35;
				item.UseSound = SoundID.Item102;
			}
			else
			{
				item.crit = 5;
				item.shootSpeed = 11f;
				item.knockBack = 5f;

				item.useTime = 24;
				item.useAnimation = 24;
				item.UseSound = SoundID.Item5;
			}
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			if (player.altFunctionUse == 2)
			{
				damage *= 2;
				type = mod.ProjectileType("HallowProj");
				int num = 1 + Main.rand.Next(3);
				for (int i = 0; i < num; i++)
				{
					Vector2 vector = Utils.RotatedByRandom(new Vector2(speedX, speedY), (double)MathHelper.ToRadians(20f));
					Projectile.NewProjectile(position.X, position.Y, vector.X, vector.Y, mod.ProjectileType("HallowProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
				}
				if (type == 1)
				{
					type = mod.ProjectileType("HallowProj");
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

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(4f, 0f);
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1225, 15);
			recipe.AddIngredient((Mod)null, "MysticString", 3);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public HallowedCrossbow()
			
		{
		}
	}
}
