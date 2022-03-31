using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SkyArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Skydrop Arrow");
			Tooltip.SetDefault("Summons a barrage of arrows from the sky");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 2f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("SkyProj");
			item.shootSpeed = 8f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(40, 25);
			recipe.AddIngredient(320, 1);
			recipe.AddIngredient(3, 1);
			recipe.AddRecipeGroup("Wood", 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}

		public SkyArrow()
			
		{
		}
	}
}
