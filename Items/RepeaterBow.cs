using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class RepeaterBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Repeater Bow");
			Tooltip.SetDefault("Shoots two arrows in quick succession");
		}

		public override void SetDefaults()
		{
			item.damage = 9;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 8;
			item.useAnimation = 15;
			item.reuseDelay = 28;
			item.useStyle = 5;
			item.knockBack = 2f;
			item.value = 1000;
			item.rare = 1;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 5.5f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool ConsumeAmmo(Player player)
		{
			Main.PlaySound(SoundID.Item5, -1, -1);
			return player.itemAnimation >= item.useAnimation - 2;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0024: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0039: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddRecipeGroup("Wood", 25);
			recipe.AddRecipeGroup("IronBar", 7);
			recipe.AddIngredient((Mod)null, "String", 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public RepeaterBow()
			
		{
		}
	}
}
