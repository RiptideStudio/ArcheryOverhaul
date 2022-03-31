using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class Armageddon : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Armageddon");
			Tooltip.SetDefault("Pummels your foe with meteor strikes");
		}

		public override void SetDefaults()
		{
			item.damage = 38;
			item.ranged = true;
			item.width = 40;
			item.height = 60;
			item.useTime = 17;
			item.useAnimation = 17;
			item.useStyle = 5;
			item.knockBack = 0.2f;
			item.value = 80000;
			item.rare = 4;
			item.noMelee = true;
			item.UseSound = SoundID.Item45;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 12f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("MeteorProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			var proj = Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 425, 0, knockback, ((Entity)player).whoAmI, 0f, 0f);
			Main.projectile[proj].arrow = true;
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "MeteorBow", 1);
			recipe.AddIngredient(117, 20);
			recipe.AddIngredient((Mod)null, "DemonicString", 5);
			recipe.AddIngredient((Mod)null, "MysticString", 5);
			recipe.AddIngredient((Mod)null, "DaoShard", 1);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public Armageddon()
			
		{
		}
	}
}
