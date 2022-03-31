using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class PurpleBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demonic Destruction");
			Tooltip.SetDefault("Shoots corrupted arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 41;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 5;
			item.knockBack = 4f;
			item.value = 50000;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 10f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("DemonProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(44, 1);
			recipe.AddIngredient((Mod)null, "PoisonShot", 1);
			recipe.AddIngredient((Mod)null, "DungeonBow", 1);
			recipe.AddIngredient(120, 1);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 5);
			recipe.AddTile(26);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public PurpleBow()
			
		{
		}
	}
}
