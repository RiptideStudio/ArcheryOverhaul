using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class KingBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("King's Bow");
			Tooltip.SetDefault("Shoots a singular, powerful arrow");
		}

		public override void SetDefaults()
		{
			item.damage = 53;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 21;
			item.useAnimation = 21;
			item.useStyle = 5;
			item.knockBack = 5f;
			item.value = 200000;
			item.rare = 4;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 12f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002f: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "ReinforcedBow3", 1);
			recipe.AddIngredient(391, 10);
			recipe.AddIngredient(19, 10);
			recipe.AddIngredient((Mod)null, "MysticString", 2);
			recipe.AddIngredient((Mod)null, "DemonicString", 2);
			recipe.AddIngredient((Mod)null, "DaoShard", 1);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public KingBow()
			
		{
		}
	}
}
