using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class OricalcumBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Oricalcum Bow");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 39;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 19;
			item.useAnimation = 19;
			item.useStyle = 5;
			item.knockBack = 4f;
			item.value = 10000;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 9.5f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1191, 12);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public OricalcumBow()
			
		{
		}
	}
}
