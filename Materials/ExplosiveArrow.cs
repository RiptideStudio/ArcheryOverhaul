using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class ExplosiveArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Explosive Arrow");
			Tooltip.SetDefault("Explodes on impact");
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 2f;
			item.value = 500;
			item.rare = 3;
			item.shoot = mod.ProjectileType("ExplosiveProj");
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
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(40, 50);
			recipe.AddIngredient(1347, 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}

		public ExplosiveArrow()
			
		{
		}
	}
}
