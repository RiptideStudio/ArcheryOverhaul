using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class TopazBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Topaz Bow");
			Tooltip.SetDefault("Shoots Topaz Arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 29;
			item.useAnimation = 29;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 10000;
			item.rare = 2;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 6f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("TopazProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(180, 12);
			recipe.AddIngredient((Mod)null, "String", 3);
			recipe.AddTile(18);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public TopazBow()
			
		{
		}
	}
}
