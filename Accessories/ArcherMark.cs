using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Accessories
{
	public class ArcherMark : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Archer's Mark");
			Tooltip.SetDefault("'Grants supreme archery prowess'\nIncreased arrow size\n18% Increased ranged damage\n12% Increased ranged critical strike chance\n25% Chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.rare = 4;
			item.value = 60000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.rangedCrit += 12;
			player.rangedDamage += 0.18f;
			player.ammoCost75 = true;
			player.ghostFade = 3f;
			player.GetModPlayer<GlobalPlayer>().target = true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "Quiver3", 1);
			recipe.AddIngredient((Mod)null, "SherwoodBracer", 1);
			recipe.AddIngredient(491, 1);
			recipe.AddIngredient(521, 5);
			recipe.AddIngredient(520, 5);
			recipe.AddTile(114);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}
	}
}
