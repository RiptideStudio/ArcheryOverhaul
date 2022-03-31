using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class TestSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Wooden Fusion");
			Tooltip.SetDefault("It's Exotic!");
		}

		public override void SetDefaults()
		{
			item.damage = 11;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 5;
			item.knockBack = 1f;
			item.value = 10000;
			item.rare = 2;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 6f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "String", 5);
			recipe.AddIngredient(39, 1);
			recipe.AddIngredient(923, 1);
			recipe.AddIngredient(2515, 1);
			recipe.AddIngredient(658, 1);
			recipe.AddTile(18);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			ModRecipe val2 = new ModRecipe(mod);
			val2.AddIngredient((Mod)null, "String", 5);
			val2.AddIngredient(39, 1);
			val2.AddIngredient(655, 1);
			val2.AddIngredient(2515, 1);
			val2.AddIngredient(658, 1);
			val2.AddTile(18);
			val2.SetResult(this, 1);
			val2.AddRecipe();
		}

		public TestSword()
			
		{
		}
	}
}
