using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class CrystalArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crystal Arrow");
			Tooltip.SetDefault("Splits into several crystal shards on impact");
		}

		public override void SetDefaults()
		{
			item.damage = 15;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 30;
			item.rare = 3;
			item.shoot = mod.ProjectileType("CrystalProj");
			item.shootSpeed = 7f;
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
			recipe.AddIngredient(40, 100);
			recipe.AddIngredient(502, 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 100);
			recipe.AddRecipe();
		}

		public CrystalArrow()
			
		{
		}
	}
}
