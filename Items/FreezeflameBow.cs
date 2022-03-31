using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class FreezeflameBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Freezeflame Bow");
			Tooltip.SetDefault("Converts wooden arrows into fire and ice");
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.ranged = true;
			item.width = 24;
			item.height = 48;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 40000;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 9f;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(6f, -2f);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int num = 1;
			float num2 = MathHelper.ToRadians(0f);
			for (int i = 0; i < num; i++)
			{
				Vector2 vector = Utils.RotatedBy(new Vector2(speedX, speedY), (double)MathHelper.Lerp(0f - num2, num2, i / num), default(Vector2));
				if (type == 1)
				{
					Projectile.NewProjectile(position.X, position.Y, vector.X, vector.Y, 172, damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
				}
				else
				{
					Projectile.NewProjectile(position.X, position.Y, vector.X, vector.Y, type, damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
				}
			}
			int num3 = 1;
			float num4 = MathHelper.ToRadians(10f);
			float num5 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num6 = Math.Atan2(speedX, speedY) - (double)(num4 / 2f);
			double num7 = num4 / (float)num3;
			for (int j = 0; j < num3; j++)
			{
				double num8 = num6 + num7 * (double)j;
				if (type == 1)
				{
					Projectile.NewProjectile(position.X, position.Y, num5 * (float)Math.Sin(num8), num5 * (float)Math.Cos(num8), 2, damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
				}
				else
				{
					Projectile.NewProjectile(position.X, position.Y, num5 * (float)Math.Sin(num8), num5 * (float)Math.Cos(num8), type, damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
				}
			}
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "LavaBow", 1);
			recipe.AddIngredient((Mod)null, "FrostBow", 1);
			recipe.AddIngredient(175, 10);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public FreezeflameBow()
			
		{
		}
	}
}
