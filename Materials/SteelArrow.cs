using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SteelArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Steel Arrow");
			Tooltip.SetDefault("Hits enemies hard");
		}

		public override void SetDefaults()
		{
			item.damage = 10;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 6.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("SteelArrowProj");
			item.shootSpeed = 10f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(40, 50);
			recipe.AddIngredient((Mod)null, "SteelBar", 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}

		public SteelArrow()
			
		{
		}
	}
}
