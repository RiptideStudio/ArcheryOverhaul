using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class DemonArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Demonic Arrow");
			Tooltip.SetDefault("Inflicts pain debuff\nRapidly destroys your opponent's soul");
		}

		public override void SetDefaults()
		{
			item.damage = 14;
			item.ranged = true;
			item.width = 4;
			item.height = 4;
			item.maxStack = 999;
			item.consumable = true;
			item.knockBack = 1f;
			item.value = 30;
			item.rare = 1;
			item.shoot = mod.ProjectileType("DemonProj");
			item.shootSpeed = 7f;
			item.ammo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(40, 25);
			recipe.AddIngredient(57, 1);
			recipe.AddIngredient(86, 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}

		public DemonArrow()
			
		{
		}
	}
}
