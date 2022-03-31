using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SolarArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Solar Arrow");
			Tooltip.SetDefault("Creates a massive solar explosion on impact");
		}

		public override void SetDefaults()
		{
			item.damage = 29;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 6f;
			item.value = 100;
			item.rare = 10;
			item.shoot = mod.ProjectileType("SolarProj");
			item.shootSpeed = 8f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(40, 100);
			recipe.AddIngredient(3458, 1);
			recipe.AddTile(412);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}

		public SolarArrow()
			
		{
		}
	}
}
