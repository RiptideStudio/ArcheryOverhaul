using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SandstormArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sandstorm Arrow");
			Tooltip.SetDefault("'It's in my eyes!'\nSummons sand from the sky on impact");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 3f;
			item.value = 50;
			item.rare = 2;
			item.shoot = mod.ProjectileType("SandstormArrowProj");
			item.shootSpeed = 5f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "SandArrow", 50);
			recipe.AddIngredient(3380, 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}

		public SandstormArrow()
			
		{
		}
	}
}
