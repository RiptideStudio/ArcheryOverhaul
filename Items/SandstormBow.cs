using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class SandstormBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Sandstorm Bow");
			Tooltip.SetDefault("Converts wooden arrows into a wave of sand");
		}

		public override void SetDefaults()
		{
			item.damage = 19;
			item.ranged = true;
			item.width = 16;
			item.height = 32;
			item.useTime = 35;
			item.useAnimation = 35;
			item.useStyle = 5;
			item.knockBack = 2f;
			item.value = 50000;
			item.rare = 3;
			item.noMelee = true;
			item.autoReuse = true;
			item.shoot = 1;
			item.shootSpeed = 7f;
			item.useAmmo = AmmoID.Arrow;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			if (type == 1)
			{
				type = mod.ProjectileType("SandstormProj");
				Main.PlaySound(SoundID.Item88.WithVolume(0.7f).WithPitchVariance(0.5f), -1, -1);
			}
			else
			{
				Main.PlaySound(SoundID.Item5, -1, -1);
			}
			return true;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "SandBow", 1);
			recipe.AddIngredient(40, 100);
			recipe.AddIngredient(323, 8);
			recipe.AddIngredient(3271, 25);
			recipe.AddIngredient(169, 50);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public SandstormBow()
			
		{
		}
	}
}
