using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class ElementalBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Elemental Wrath");
			Tooltip.SetDefault("Unleash the wrath of the elements\nEffects of all elemental bows");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(8f, 0f);
		}

		public override void SetDefaults()
		{
			item.damage = 78;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 4f;
			item.value = 500000;
			item.rare = 9;
			item.noMelee = true;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 11f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 706, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("ElementalProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 337, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			Main.PlaySound(SoundID.Item88.WithVolume(0.7f).WithPitchVariance(0.5f), -1, -1);
			int num = 1;
			float num2 = MathHelper.ToRadians(10f);
			float num3 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num4 = Math.Atan2(speedX, speedY) - (double)(num2 / 2f);
			double num5 = num2 / (float)num;
			for (int i = 0; i < num; i++)
			{
				double num6 = num4 + num5 * (double)i;
				Projectile.NewProjectile(position.X, position.Y, num3 * (float)Math.Sin(num6), num3 * (float)Math.Cos(num6), 709, damage / 2, knockback, ((Entity)player).whoAmI, 0f, 0f);
				Projectile.NewProjectile(position.X, position.Y, num3 * (float)Math.Sin(num6), num3 * (float)Math.Cos(num6), 337, damage / 2, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			int num7 = 1;
			float num8 = MathHelper.ToRadians(-10f);
			float num9 = (float)Math.Sqrt(speedX * speedX + speedY * speedY);
			double num10 = Math.Atan2(speedX, speedY) - (double)(num8 / 2f);
			double num11 = num8 / (float)num7;
			for (int j = 0; j < num; j++)
			{
				double num12 = num10 + num11 * (double)j;
				Projectile.NewProjectile(position.X, position.Y, num9 * (float)Math.Sin(num12), num9 * (float)Math.Cos(num12), 709, damage / 2, knockback, ((Entity)player).whoAmI, 0f, 0f);
				Projectile.NewProjectile(position.X, position.Y, num9 * (float)Math.Sin(num12), num9 * (float)Math.Cos(num12), 337, damage / 2, knockback, ((Entity)player).whoAmI, 0f, 0f);
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
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_008d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "CloudBow", 1);
			recipe.AddIngredient((Mod)null, "ColdBow", 1);
			recipe.AddIngredient((Mod)null, "CrystalStrike", 1);
			recipe.AddIngredient((Mod)null, "HallowBow", 1);
			recipe.AddIngredient((Mod)null, "FreezeflameBow", 1);
			recipe.AddIngredient((Mod)null, "SandstormBow", 1);
			recipe.AddIngredient((Mod)null, "CursedBow", 1);
			recipe.AddIngredient((Mod)null, "DaoShard", 10);
			recipe.AddIngredient(1508, 10);
			recipe.AddIngredient(548, 5);
			recipe.AddIngredient(549, 5);
			recipe.AddIngredient(547, 5);
			recipe.AddTile(412);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public ElementalBow()
			
		{
		}
	}
}
