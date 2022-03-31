using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class AdamantiteBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Bow");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 43;
			item.ranged = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 18;
			item.useAnimation = 18;
			item.useStyle = 5;
			item.knockBack = 4f;
			item.value = 10000;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(391, 12);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public AdamantiteBow()
			
		{
		}
	}
}
