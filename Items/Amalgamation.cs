using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class Amalgamation : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amalgamation");
			Tooltip.SetDefault("'Speed, power, and a lotta arrows!'\nShoots a spread of powerful arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 61;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 5f;
			item.value = 500000;
			item.rare = 7;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 14f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int num = 1;
			float num2 = MathHelper.ToRadians(0f);
			for (int i = 0; i < num; i++)
			{
				Vector2 vector = Utils.RotatedBy(new Vector2(speedX, speedY), (double)MathHelper.Lerp(0f - num2, num2, i / num), default(Vector2));
				Projectile.NewProjectile(position.X, position.Y, vector.X, vector.Y, type, damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
			}
			int num3 = 1;
			float num4 = MathHelper.ToRadians(10f);
			float num5 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num6 = Math.Atan2(speedX, speedY) - (double)(num4 / 2f);
			double num7 = num4 / (float)num3;
			for (int j = 0; j < num3; j++)
			{
				double num8 = num6 + num7 * (double)j;
				Projectile.NewProjectile(position.X, position.Y, num5 * (float)Math.Sin(num8), num5 * (float)Math.Cos(num8), type, damage / 2, knockBack, ((Entity)player).whoAmI, 0f, 0f);
			}
			int num9 = 1;
			float num10 = MathHelper.ToRadians(-10f);
			float num11 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num12 = Math.Atan2(speedX, speedY) - (double)(num10 / 2f);
			double num13 = num10 / (float)num9;
			for (int k = 0; k < num3; k++)
			{
				double num14 = num12 + num13 * (double)k;
				Projectile.NewProjectile(position.X, position.Y, num11 * (float)Math.Sin(num14), num11 * (float)Math.Cos(num14), type, damage / 2, knockBack, ((Entity)player).whoAmI, 0f, 0f);
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
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			//IL_0070: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "KingBow", 1);
			recipe.AddIngredient((Mod)null, "HyperBow", 1);
			recipe.AddIngredient((Mod)null, "TripleShot", 1);
			recipe.AddIngredient(1225, 10);
			recipe.AddIngredient(548, 5);
			recipe.AddIngredient(547, 5);
			recipe.AddIngredient(549, 5);
			recipe.AddIngredient((Mod)null, "DaoShard", 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public Amalgamation()
			
		{
		}
	}
}
