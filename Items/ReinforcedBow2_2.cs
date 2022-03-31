using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class ReinforcedBow2_2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Longshot");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 24;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 20000;
			item.rare = 2;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 8f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "ReinforcedBow", 1);
			recipe.AddIngredient(706, 5);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 3);
			recipe.AddTile(16);
			recipe.SetResult((Mod)null, "ReinforcedBow2", 1);
			recipe.AddRecipe();
		}

		public ReinforcedBow2_2()
			
		{
		}
	}
}
