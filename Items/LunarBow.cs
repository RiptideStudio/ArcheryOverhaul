using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class LunarBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Bow");
			Tooltip.SetDefault("Summons a fallen star");
		}

		public override void SetDefaults()
		{
			item.damage = 17;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 2f;
			item.value = 30000;
			item.rare = 2;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 503;
			item.shootSpeed = 7f;
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
				Projectile.NewProjectile(position.X, position.Y, speedX * 2.1f, speedY * 2.1f, 12, damage, knockBack, ((Entity)player).whoAmI, 0f, num);
			}
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0034: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(39, 1);
			recipe.AddIngredient(19, 10);
			recipe.AddIngredient(75, 5);
			recipe.AddIngredient((Mod)null, "String", 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			ModRecipe val2 = new ModRecipe(mod);
			val2.AddIngredient(39, 1);
			val2.AddIngredient(706, 10);
			val2.AddIngredient(75, 5);
			val2.AddIngredient((Mod)null, "String", 3);
			val2.AddTile(16);
			val2.SetResult(this, 1);
			val2.AddRecipe();
		}

		public LunarBow()
			
		{
		}
	}
}
