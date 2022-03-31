using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace bowmod.Items
{
	public class GaleBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Heavenly Volley");
			Tooltip.SetDefault("'The power of God lies in your hand'\nThere is no limit to your power");
		}

		public override void SetDefaults()
		{
			item.damage = 180;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 10;
			item.useAnimation = 10;
			item.useStyle = 5;
			item.knockBack = 7f;
			item.value = 1000000;
			item.rare = 11;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 12f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			int num = 5;
			Projectile.NewProjectile(position.X, position.Y, speedX / 4f, speedY / 4f, 409, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			for (int i = 0; i < num; i++)
			{
				Main.PlaySound(SoundID.Item88.WithVolume(0.7f).WithPitchVariance(0.5f), -1, -1);
				float num2 = MathHelper.ToRadians(12f);
				float num3 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
				double num4 = Math.Atan2(speedX, speedY) - (double)(num2 / 2f);
				double num5 = num2 / (float)num;
				double num6 = num4 + num5 * (double)i;
				Projectile.NewProjectile(position.X, position.Y, num3 * (float)Math.Sin(num6), num3 * (float)Math.Cos(num6), type, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);

			}
			Vector2 vector = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY);
			float num7 = vector.Y;
			if (num7 > player.Center.Y - 200f)
			{
				num7 = player.Center.Y - 200f;
			}
			for (int j = 0; j < 1; j++)
			{
				position = player.Center + new Vector2((0f - (float)Main.rand.Next(0, 250)) * (float)((Entity)player).direction, -600f);
				position.Y -= 100 * j;
				Vector2 vector2 = vector - position;
				if (vector2.Y < 0f)
				{
					vector2.Y *= -1f;
				}
				if (vector2.Y < 20f)
				{
					vector2.Y = 20f;
				}
				vector2.Normalize();
				vector2 *= new Vector2(speedX, speedY).Length();
				speedX = vector2.X;
				speedY = vector2.Y + (float)Main.rand.Next(-40, 41) * 0.01f;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 503, damage, knockback, ((Entity)player).whoAmI, 0f, num7);
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 294, damage, knockback, ((Entity)player).whoAmI, 0f, num7);
				Vector2 vector3 = Utils.RotatedByRandom(new Vector2(speedX, speedY), (double)MathHelper.ToRadians(10f));
				speedX = vector3.X;
				speedY = vector3.Y;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 296, damage, knockback, ((Entity)player).whoAmI, 0f, num7);
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 503, damage, knockback, ((Entity)player).whoAmI, 0f, num7);
			}
			return true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "WaterWrath", 1);
			recipe.AddIngredient((Mod)null, "ElementalBow", 1);
			recipe.AddIngredient((Mod)null, "SpectralShot", 1);
			recipe.AddIngredient((Mod)null, "LunarWrath", 1);
			recipe.AddIngredient((Mod)null, "Eclipse", 1);
			recipe.AddIngredient(3467, 10);
			recipe.AddIngredient(3458, 5);
			recipe.AddIngredient(3457, 5);
			recipe.AddIngredient(3456, 5);
			recipe.AddIngredient(3459, 5);
			recipe.AddTile(412);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(2f, 0f);
		}

	}
}
