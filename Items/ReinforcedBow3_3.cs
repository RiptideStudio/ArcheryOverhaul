using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class ReinforcedBow3_3 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Greatbow");
			Tooltip.SetDefault("");
		}

		public override void SetDefaults()
		{
			item.damage = 38;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 22;
			item.useAnimation = 22;
			item.useStyle = 5;
			item.knockBack = 4f;
			item.value = 10000;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 9f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "ReinforcedBow2", 1);
			recipe.AddIngredient(1257, 12);
			recipe.AddIngredient((Mod)null, "SteelBar", 5);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 5);
			recipe.AddTile(16);
			recipe.SetResult(mod.ItemType("ReinforcedBow3"), 1);
			recipe.AddRecipe();
		}

		public ReinforcedBow3_3()
			
		{
		}
	}
}
