using Terraria;
using Terraria.DataStructures;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	public class ElementalRock : ModItem
	{
		public override void SetStaticDefaults()
		{
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Expected O, but got Unknown
			DisplayName.SetDefault("Elemental Arrow Stone");
			Tooltip.SetDefault("'Ancient archery magic fules you'\nEffects of all arrow stones\nGrants immunity to knockback and fire blocks");
			Main.RegisterItemAnimation(item.type, (DrawAnimation)new DrawAnimationVertical(6, 5));
		}

		public override void SetDefaults()
		{
			item.width = 101;
			item.height = 28;
			item.rare = 8;
			item.value = 500003;
			item.defense = 10;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.fireWalk = true;
			player.noKnockback = true;
			player.moveSpeed += 0.25f;
			player.accRunSpeed = 7.25f;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "ArrowRock", 1);
			recipe.AddIngredient((Mod)null, "WaterStone", 1);
			recipe.AddIngredient((Mod)null, "AirStone", 1);
			recipe.AddIngredient((Mod)null, "FireArrowStone", 1);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public ElementalRock()
			
		{
		}
	}
}
