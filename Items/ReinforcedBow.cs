using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class ReinforcedBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Longbow");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 17;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 32;
			item.useAnimation = 32;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 10000;
			item.rare = 1;
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
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(39, 1);
			recipe.AddRecipeGroup("IronBar", 7);
			recipe.AddIngredient((Mod)null, "String", 5);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public ReinforcedBow()
			
		{
		}
	}
}
