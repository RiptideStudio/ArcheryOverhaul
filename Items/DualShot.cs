using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class DualShot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dual Shot");
			Tooltip.SetDefault("Shoots two rounds of two arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 12;
			item.useAnimation = 24;
			item.reuseDelay = 27;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 50000;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool ConsumeAmmo(Player player)
		{
			Main.PlaySound(SoundID.Item5, -1, -1);
			return true;
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
				Projectile.NewProjectile(position.X, position.Y, num5 * (float)Math.Sin(num8), num5 * (float)Math.Cos(num8), type, damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
			}
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "ClockworkBow", 1);
			recipe.AddIngredient((Mod)null, "CrimsonArrow", 25);
			recipe.AddIngredient(1257, 12);
			recipe.AddIngredient((Mod)null, "SteelBar", 5);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 5);
			recipe.AddTile(16);
			recipe.SetResult(mod.ItemType("DualShot"), 1);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient((Mod)null, "ClockworkBow", 1);
			recipe2.AddIngredient((Mod)null, "DemonArrow", 25);
			recipe2.AddIngredient(57, 12);
			recipe2.AddIngredient((Mod)null, "SteelBar", 5);
			recipe2.AddIngredient((Mod)null, "ReinforcedString", 5);
			recipe2.AddTile(16);
			recipe2.SetResult(mod.ItemType("DualShot"), 1);
			recipe2.AddRecipe();
		}

		public DualShot()
			
		{
		}
	}
}
