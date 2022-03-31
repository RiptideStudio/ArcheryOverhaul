using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	[AutoloadEquip(EquipType.Back)]
	public class FireQuiver : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flaming Quiver");
			Tooltip.SetDefault("20% Chance not to consume ammo\nConverts wooden arrows into flaming arrows");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 0;
			item.rare = 2;
			item.value = 15000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool showVisual)
		{
			player.ammoBox = true;
			for (int i = 0; i < 50; i++)
			{
				Projectile recipe = Main.projectile[i];
				if (recipe.type == 1)
				{
					recipe.type = 2;
				}
			}
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "Quiver", 1);
			recipe.AddIngredient(41, 100);
			recipe.AddIngredient(207, 1);
			recipe.AddIngredient(318, 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public FireQuiver()
			
		{
		}
	}
}
