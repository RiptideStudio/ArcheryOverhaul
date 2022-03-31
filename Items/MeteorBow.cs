using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class MeteorBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Meteoric Burst");
			Tooltip.SetDefault("Converts wooden arrows into a powerful meteoric strike\nSummons meteors from the sky on impact");
		}

		public override void SetDefaults()
		{
			item.damage = 24;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 0.1f;
			item.value = 30000;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 11f;
		}
		public override Vector2? HoldoutOffset()
		{
			return new Vector2(4f, 2f);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			if (type == 1)
			{
				Main.PlaySound(SoundID.Item45, (int)player.position.X, (int)player.position.Y); // Play a death sound
				type = mod.ProjectileType("MeteorProj");
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("MeteorProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
				var proj = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 425, 0, knockback, ((Entity)player).whoAmI, 0f, 0f);
				Main.projectile[proj].arrow = true;
			}

			return true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(117, 20);
			recipe.AddIngredient(75, 5);
			recipe.AddIngredient((Mod)null, "String", 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public MeteorBow()
			
		{
		}
	}
}
