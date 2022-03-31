using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class AlloyArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Dormant Arrow");
			Tooltip.SetDefault("Bursts into flames on impact\nInflicts solar flame debuff");
		}

		public override void SetDefaults()
		{
			item.damage = 23;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 750;
			item.rare = 3;
			item.shoot = mod.ProjectileType("AlloyProj");
			item.shootSpeed = 7f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(40, 50);
			recipe.AddIngredient((Mod)null, "DwarfAlloy", 1);
			recipe.AddTile(134);
			recipe.SetResult(this, 50);
			recipe.AddRecipe();
		}

		public AlloyArrow()
			
		{
		}
	}
}
