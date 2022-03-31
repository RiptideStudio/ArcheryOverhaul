using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class Grenade1 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Arrow Grenade");
			Tooltip.SetDefault("Explodes into multiple arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 11;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.useAnimation = 25;
			item.useTime = 25;
			item.maxStack = 999;
			item.UseSound = SoundID.Item1;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 300;
			item.noMelee = true;
			item.noUseGraphic = true;
			item.useStyle = 1;
			item.rare = 2;
			item.shoot = mod.ProjectileType("GrenadeProj1");
			item.shootSpeed = 7f;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(168, 5);
			recipe.AddIngredient(40, 50);
			recipe.AddRecipeGroup("Wood", 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 5);
			recipe.AddRecipe();
		}

		public Grenade1()
			
		{
		}
	}
}
