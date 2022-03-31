using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class Swiftshot : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Swift Shot");
			Tooltip.SetDefault("'May your arrows go swift and far'");
		}

		public override void SetDefaults()
		{
			item.damage = 19;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 14;
			item.useAnimation = 14;
			item.useStyle = 5;
			item.knockBack = 2f;
			item.value = 100000;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 7.5f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "Rapidfire", 1);
			recipe.AddIngredient(57, 12);
			recipe.AddIngredient((Mod)null, "SteelHide", 3);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 5);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient((Mod)null, "Rapidfire", 1);
			recipe2.AddIngredient(1257, 12);
			recipe2.AddIngredient((Mod)null, "SteelHide", 3);
			recipe2.AddIngredient((Mod)null, "ReinforcedString", 5);
			recipe2.AddTile(16);
			recipe2.SetResult(mod.ItemType("Swiftshot"), 1);
			recipe2.AddRecipe();
		}

		public Swiftshot()
			
		{
		}
	}
}
