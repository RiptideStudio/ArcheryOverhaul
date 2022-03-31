using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class CrimsonBowTrue : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Crimson Death");
			Tooltip.SetDefault("Shoots a spread of life-sucking arrows\nThe central arrow pierces and lifesteals");
		}

		public override void SetDefaults()
		{
			item.damage = 58;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.knockBack = 5f;
			item.value = 500000;
			item.rare = 8;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 12f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int num = 1;
			float num2 = MathHelper.ToRadians(0f);
			for (int i = 0; i < num; i++)
			{
				Vector2 vector = Utils.RotatedBy(new Vector2(speedX, speedY), (double)MathHelper.Lerp(0f - num2, num2, i / num), default(Vector2));
				Projectile.NewProjectile(position.X, position.Y, vector.X * 2f, vector.Y * 2f, mod.ProjectileType("TrueRedProj"), damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
			}
			int num3 = 1;
			float num4 = MathHelper.ToRadians(7f);
			float num5 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num6 = Math.Atan2(speedX, speedY) - (double)(num4 / 2f);
			double num7 = num4 / (float)num3;
			for (int j = 0; j < num3; j++)
			{
				double num8 = num6 + num7 * (double)j;
				Projectile.NewProjectile(position.X, position.Y, num5 * (float)Math.Sin(num8), num5 * (float)Math.Cos(num8), mod.ProjectileType("CrimsonProj"), damage / 2, knockBack, ((Entity)player).whoAmI, 0f, 0f);
			}
			int num9 = 1;
			float num10 = MathHelper.ToRadians(-7f);
			float num11 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num12 = Math.Atan2(speedX, speedY) - (double)(num10 / 2f);
			double num13 = num10 / (float)num9;
			for (int k = 0; k < num3; k++)
			{
				double num14 = num12 + num13 * (double)k;
				Projectile.NewProjectile(position.X, position.Y, num11 * (float)Math.Sin(num14), num11 * (float)Math.Cos(num14), mod.ProjectileType("CrimsonProj"), damage / 2, knockBack, ((Entity)player).whoAmI, 0f, 0f);
			}
			return false;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(4f, -2f);
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "CrimsonBow", 1);
			recipe.AddIngredient((Mod)null, "BrokenBow", 1);
			recipe.AddTile(26);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public CrimsonBowTrue()
			
		{
		}
	}
}
