using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class FlamarangBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Flowmerang");
			Tooltip.SetDefault("If you've made this, you are truly lost.\nRandomly shoots hellfire arrows in any direction");
		}

		public override void SetDefaults()
		{
			item.damage = 31;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 2f;
			item.value = 5000;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("FlamarangProj");
			item.shootSpeed = 10f;
			item.noUseGraphic = true;
		}

		public override bool CanUseItem(Player player)
		{
			for (int i = 0; i < 1000; i++)
			{
				if (((Entity)Main.projectile[i]).active && Main.projectile[i].owner == Main.myPlayer && Main.projectile[i].type == item.shoot)
				{
					return false;
				}
			}
			return true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(175, 15);
			recipe.AddIngredient((Mod)null, "BoomerangBow", 1);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public FlamarangBow()
			
		{
		}
	}
}
