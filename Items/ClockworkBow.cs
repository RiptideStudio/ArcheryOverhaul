using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class ClockworkBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Clockwork Bow");
			Tooltip.SetDefault("Shoots three arrows in quick succession");
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 10;
			item.useAnimation = 29;
			item.reuseDelay = 31;
			item.useStyle = 5;
			item.knockBack = 2.5f;
			item.value = 10000;
			item.rare = 2;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 7f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool ConsumeAmmo(Player player)
		{
			Main.PlaySound(SoundID.Item5, -1, -1);
			return true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "RepeaterBow", 1);
			recipe.AddRecipeGroup("Wood", 25);
			recipe.AddIngredient(19, 10);
			recipe.AddRecipeGroup("IronBar", 5);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 5);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient((Mod)null, "RepeaterBow", 1);
			recipe2.AddRecipeGroup("Wood", 25);
			recipe2.AddIngredient(706, 10);
			recipe2.AddRecipeGroup("IronBar", 5);
			recipe2.AddIngredient((Mod)null, "ReinforcedString", 5);
			recipe2.AddTile(16);
			recipe2.SetResult(mod.ItemType("ClockworkBow"), 1);
			recipe2.AddRecipe();
		}

		public ClockworkBow()
			
		{
		}
	}
}
