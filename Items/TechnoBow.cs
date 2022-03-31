using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class TechnoBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Technobow");
			Tooltip.SetDefault("Insanely fast, but inaccurate\nCousin of the Megashark");
		}

		public override void SetDefaults()
		{
			item.damage = 35;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 8;
			item.useAnimation = 8;
			item.useStyle = 5;
			item.knockBack = 2f;
			item.value = 100000;
			item.rare = 5;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 vector = Utils.RotatedByRandom(new Vector2(speedX, speedY), (double)MathHelper.ToRadians(12f));
			speedX = vector.X;
			speedY = vector.Y;
			return true;
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
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "MachineBow", 1);
			recipe.AddIngredient(548, 20);
			recipe.AddIngredient(1225, 10);
			recipe.AddIngredient((Mod)null, "DemonicString", 3);
			recipe.AddIngredient((Mod)null, "MysticString", 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public TechnoBow()
			
		{
		}
	}
}
