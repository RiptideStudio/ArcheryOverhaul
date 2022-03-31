using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class Rapidfire2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rapidfire");
			Tooltip.SetDefault("It's even faster!");
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 16;
			item.useAnimation = 16;
			item.useStyle = 5;
			item.knockBack = 1.5f;
			item.value = 50000;
			item.rare = 2;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 7f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "RapidBow", 1);
			recipe.AddIngredient(706, 5);
			recipe.AddIngredient((Mod)null, "ReinforcedHide", 3);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 3);
			recipe.AddTile(16);
			recipe.SetResult(mod.ItemType("Rapidfire"), 1);
			recipe.AddRecipe();
		}

		public Rapidfire2()
			
		{
		}
	}
}
