using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SandArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sandstone Arrow");
			Tooltip.SetDefault("High-velocity confusing arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 30;
			item.rare = 1;
			item.shoot = mod.ProjectileType("SandProj");
			item.shootSpeed = 8f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(40, 25);
			recipe.AddIngredient(3271, 2);
			recipe.AddIngredient(169, 2);
			recipe.AddTile(18);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}

		public SandArrow()
			
		{
		}
	}
}
