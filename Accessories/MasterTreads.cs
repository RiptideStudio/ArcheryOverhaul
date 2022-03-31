using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	public class MasterTreads : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Master Treads");
			Tooltip.SetDefault("Allows flight\nThe wearer can run ultra-fast\nMovement speed increased by 30%\nMaximum movement speed increased by 35%\nGrants immunity to fire-blocks\nAllows the wearer to run on water and lava\nSometimes grants a shadow-dodge");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 0;
			item.rare = 10;
			item.value = 30000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.moveSpeed += 0.5f;
			player.accRunSpeed = 9f;
			player.rocketBoots = 3;
			player.lavaMax = 60;
			player.noFallDmg = true;
			player.fireWalk = true;
			player.lavaImmune = true;
			player.waterWalk = true;
			player.onHitDodge = true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "RogueEmblem", 1);
			recipe.AddIngredient(908, 1);
			recipe.AddIngredient(976, 1);
			recipe.AddIngredient(963, 1);
			recipe.AddTile(412);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public MasterTreads()
			
		{
		}
	}
}
