using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class BoomerangBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Bowmerang");
			Tooltip.SetDefault("Now this... this scares me.\nRandomly shoots arrows in any direction");
		}

		public override void SetDefaults()
		{
			item.damage = 13;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 2f;
			item.value = 5000;
			item.rare = 1;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("BoomerangProj");
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
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(55, 1);
			recipe.AddIngredient(40, 100);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public BoomerangBow()
			
		{
		}
	}
}
