using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class HyperBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Hyperdrive Bow");
			Tooltip.SetDefault("'Activate the hyper drive!'\nRapidly shoots arrows");
		}

		public override void SetDefaults()
		{
			item.damage = 33;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 9;
			item.useAnimation = 9;
			item.useStyle = 5;
			item.knockBack = 2.5f;
			item.value = 100000;
			item.rare = 4;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 8f;
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
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "Swiftshot", 1);
			recipe.AddIngredient(1198, 10);
			recipe.AddIngredient((Mod)null, "MysticString", 5);
			recipe.AddIngredient((Mod)null, "DaoShard", 3);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public HyperBow()
			
		{
		}
	}
}
