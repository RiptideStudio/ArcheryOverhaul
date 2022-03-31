using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class GraniteArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Granite Arrow");
			Tooltip.SetDefault("High-damaging arrow");
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 50;
			item.rare = 2;
			item.shoot = mod.ProjectileType("GraniteProj");
			item.shootSpeed = 6f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3086, 1);
			recipe.AddIngredient(3087, 1);
			recipe.AddIngredient(40, 50);
			recipe.AddTile(16);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}

		public GraniteArrow()
			
		{
		}
	}
}
