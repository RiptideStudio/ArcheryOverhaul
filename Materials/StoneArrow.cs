using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class StoneArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Stone Arrow");
			Tooltip.SetDefault("Hits enemies hard");
		}

		public override void SetDefaults()
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 5f;
			item.value = 30;
			item.rare = 1;
			item.shoot = mod.ProjectileType("StoneProj");
			item.shootSpeed = 6f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(40, 25);
			recipe.AddIngredient(3, 2);
			recipe.AddTile(18);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}

		public StoneArrow()
			
		{
		}
	}
}
