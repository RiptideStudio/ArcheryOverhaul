using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	public class RogueEmblem : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Apprentice Treads");
			Tooltip.SetDefault("Allows flight\nThe wearer can run super fast\nMovement speed increased by 25%\nMaximum movement speed increased by 25%");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 0;
			item.rare = 3;
			item.value = 30000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.moveSpeed += 0.4f;
			player.accRunSpeed = 7.5f;
			player.rocketBoots = 3;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(128, 1);
			recipe.AddIngredient((Mod)null, "RogueBoots", 1);
			recipe.AddIngredient((Mod)null, "ArcherBand", 1);
			recipe.AddIngredient(212, 1);
			recipe.AddTile(114);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public RogueEmblem()
			
		{
		}
	}
}
