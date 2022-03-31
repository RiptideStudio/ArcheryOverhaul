using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class LunarWrath : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Wrath");
			Tooltip.SetDefault("'The sky is falling!'");
		}

		public override void SetDefaults()
		{
			item.damage = 37;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 300000;
			item.rare = 5;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 503;
			item.shootSpeed = 9f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, type, damage, knockBack, ((Entity)player).whoAmI, 0f, 0f);
			Vector2 vector = Main.screenPosition + new Vector2(Main.mouseX, Main.mouseY);
			float num = vector.Y;
			if (num > player.Center.Y - 200f)
			{
				num = player.Center.Y - 200f;
			}
			for (int i = 0; i < 1; i++)
			{
				position = player.Center + new Vector2((0f - (float)Main.rand.Next(0, 250)) * (float)((Entity)player).direction, -600f);
				position.Y -= 100 * i;
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
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 503, damage, knockBack, ((Entity)player).whoAmI, 0f, num);
				Vector2 vector3 = Utils.RotatedByRandom(new Vector2(speedX, speedY), (double)MathHelper.ToRadians(10f));
				speedX = vector3.X;
				speedY = vector3.Y;
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 503, damage, knockBack, ((Entity)player).whoAmI, 0f, num);
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
			recipe.AddIngredient((Mod)null, "LunarBow", 1);
			recipe.AddIngredient(549, 20);
			recipe.AddIngredient((Mod)null, "MysticShard", 5);
			recipe.AddIngredient((Mod)null, "MysticString", 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public LunarWrath()
			
		{
		}
	}
}
