using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Accessories
{
	public class HomingSensor : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Homing Sensor");
			Tooltip.SetDefault("'Pew pew!'\nSlows down arrows\nArrows will home in on the enemy");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.rare = 5;
			item.value = 300001;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.GetModPlayer<GlobalPlayer>().homingSensor = true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(1225, 12);
			recipe.AddIngredient((Mod)null, "DwarfAlloy", 6);
			recipe.AddIngredient(548, 10);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public HomingSensor()
			
		{
		}
	}
}
