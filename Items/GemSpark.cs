using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class GemSpark : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Gemspark Bow");
			Tooltip.SetDefault("Gem infused fury\nShoots 3 prismatic arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 21;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 25;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.knockBack = 4f;
			item.value = 100000;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int num = 1;
			float num2 = MathHelper.ToRadians(-10f);
			float num3 = MathHelper.ToRadians(10f);
			for (int i = 0; i < num; i++)
			{
				Vector2 vector = Utils.RotatedBy(new Vector2(speedX, speedY), (double)MathHelper.Lerp(0f - num2, num2, i / num), default(Vector2));
				Projectile.NewProjectile(position.X, position.Y, vector.X, vector.Y, mod.ProjectileType("GemProj"), damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
			}
			for (int j = 0; j < num; j++)
			{
				Vector2 vector2 = Utils.RotatedBy(new Vector2(speedX, speedY), (double)MathHelper.Lerp(0f - num3, num3, j / num), default(Vector2));
				Projectile.NewProjectile(position.X, position.Y, vector2.X, vector2.Y, mod.ProjectileType("GemProj"), damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
			}
			Projectile.NewProjectile(position.X, position.Y + 8f, speedX, speedY, mod.ProjectileType("GemProj"), damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
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
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "AmethystBow", 1);
			recipe.AddIngredient((Mod)null, "TopazBow", 1);
			recipe.AddIngredient((Mod)null, "SapphireBow", 1);
			recipe.AddIngredient((Mod)null, "EmeraldBow", 1);
			recipe.AddIngredient((Mod)null, "AmberBow", 1);
			recipe.AddIngredient((Mod)null, "RubyBow", 1);
			recipe.AddIngredient((Mod)null, "DiamondBow", 1);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 5);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public GemSpark()
			
		{
		}
	}
}
