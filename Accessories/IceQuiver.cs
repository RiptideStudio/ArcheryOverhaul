using Terraria;
using Terraria.ModLoader;

namespace bowmod.Accessories
{
	[AutoloadEquip(EquipType.Back)]
	public class IceQuiver : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Frozen Quiver");
			Tooltip.SetDefault("20% Chance not to consume ammo\nConverts wooden arrows into frostburn arrows");
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
					recipe.type = 172;
				}
			}
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "Quiver", 1);
			recipe.AddIngredient(988, 100);
			recipe.AddIngredient(2503, 20);
			recipe.AddIngredient(2358, 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public IceQuiver()
			
		{
		}
	}
}
