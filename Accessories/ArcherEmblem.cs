using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Accessories
{
	public class ArcherEmblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Archer Emblem");
			Tooltip.SetDefault("7% Increased ranged critical strike chance\n7% Increased arrow damage\nArrow penetration increased by 1\nEffects of Target");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.rare = 2;
			item.value = 30000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.rangedCrit += 7;
			player.rangedDamage += 0.07f;
			player.ghostFade = 1f;
			player.GetModPlayer<GlobalPlayer>().target = true;
			player.GetModPlayer<GlobalPlayer>().sharpFlint = true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "ArrowCarver", 1);
			recipe.AddIngredient((Mod)null, "Flint", 1);
			recipe.AddIngredient((Mod)null, "Target", 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public ArcherEmblem()
			
		{
		}
	}
}
