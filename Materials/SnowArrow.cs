using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class SnowArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Snowball Arrow");
			Tooltip.SetDefault("Explodes into snowballs\nFrosty's arch-nemesis");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 3f;
			item.value = 50;
			item.rare = 1;
			item.shoot = mod.ProjectileType("SnowProj");
			item.shootSpeed = 5f;
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
			recipe.AddIngredient(40, 25);
			recipe.AddIngredient(593, 1);
			recipe.AddTile(18);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}

		public SnowArrow()
			
		{
		}
	}
}
