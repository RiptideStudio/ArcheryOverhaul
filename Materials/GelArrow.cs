using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class GelArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Geltic Arrow");
			Tooltip.SetDefault("Has a certain bouncy quality...");
		}

		public override void SetDefaults()
		{
			item.damage = 8;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 2f;
			item.value = 30;
			item.rare = 1;
			item.shoot = mod.ProjectileType("GelProj");
			item.shootSpeed = 5f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(40, 25);
			recipe.AddIngredient(23, 1);
			recipe.AddTile(18);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}

		public GelArrow()
			
		{
		}
	}
}
