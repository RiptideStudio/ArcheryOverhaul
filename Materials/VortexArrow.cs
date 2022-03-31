using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class VortexArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Vortex Arrow");
			Tooltip.SetDefault("Chases your enemy around");
		}

		public override void SetDefaults()
		{
			item.damage = 26;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 3f;
			item.value = 100;
			item.rare = 10;
			item.shoot = mod.ProjectileType("VortexProj");
			item.shootSpeed = 1f;
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
			recipe.AddIngredient(3456, 1);
			recipe.AddTile(412);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}

		public VortexArrow()
			
		{
		}
	}
}
