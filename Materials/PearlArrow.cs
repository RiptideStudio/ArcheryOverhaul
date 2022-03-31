using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class PearlArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pearlstone Arrow");
			Tooltip.SetDefault("Hits hard");
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 4f;
			item.value = 200;
			item.rare = 3;
			item.shoot = mod.ProjectileType("PearlProj");
			item.shootSpeed = 6f;
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
			recipe.AddIngredient(40, 50);
			recipe.AddIngredient(409, 1);
			recipe.AddIngredient(621, 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}

		public PearlArrow()
			
		{
		}
	}
}
