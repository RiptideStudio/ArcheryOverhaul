using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class WaterWrath : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Poseidon's Wrath");
			Tooltip.SetDefault("'Annihilate your opponents with the power of the ocean'\nLaunches an assortment of oceanic attacks");
		}

		public override void SetDefaults()
		{
			item.damage = 85;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.knockBack = 4f;
			item.value = 700000;
			item.rare = 11;
			item.noMelee = true;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 11f;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(2f, 0f);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("SurgeProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 405, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			Main.PlaySound(SoundID.Item88.WithVolume(0.7f).WithPitchVariance(0.5f), -1, -1);
			int num = 1;
			float num2 = MathHelper.ToRadians(10f);
			float num3 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num4 = Math.Atan2(speedX, speedY) - (double)(num2 / 2f);
			double num5 = num2 / (float)num;
			for (int i = 0; i < num; i++)
			{
				double num6 = num4 + num5 * (double)i;
				Projectile.NewProjectile(position.X, position.Y, num3 * (float)Math.Sin(num6), num3 * (float)Math.Cos(num6), 408, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
				Projectile.NewProjectile(position.X, position.Y, num3 / 3f * (float)Math.Sin(num6), num3 / 2f * (float)Math.Cos(num6), 409, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
				Projectile.NewProjectile(position.X, position.Y, num3 / 2f * (float)Math.Sin(num6), num3 / 2f * (float)Math.Cos(num6), 405, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			int num7 = 1;
			float num8 = MathHelper.ToRadians(-10f);
			float num9 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num10 = Math.Atan2(speedX, speedY) - (double)(num8 / 2f);
			double num11 = num8 / (float)num7;
			for (int j = 0; j < num; j++)
			{
				double num12 = num10 + num11 * (double)j;
				Projectile.NewProjectile(position.X, position.Y, num9 * (float)Math.Sin(num12), num9 * (float)Math.Cos(num12), 408, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
				Projectile.NewProjectile(position.X, position.Y, num9 / 3f * (float)Math.Sin(num12), num9 / 2f * (float)Math.Cos(num12), 409, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
				Projectile.NewProjectile(position.X, position.Y, num9 / 2f * (float)Math.Sin(num12), num9 / 2f * (float)Math.Cos(num12), 405, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(2624, 1);
			recipe.AddIngredient((Mod)null, "DungeonBow", 1);
			recipe.AddIngredient((Mod)null, "String", 10);
			recipe.AddTile(412);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public WaterWrath()
			
		{
		}
	}
}
