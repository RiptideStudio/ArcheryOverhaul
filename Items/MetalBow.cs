using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Items
{
	public class MetalBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Metal Burst");
			Tooltip.SetDefault("Shoots A Mesh Of Steel");
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(6f, 0f);
		}

		public override void SetDefaults()
		{
			item.damage = 26;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 30;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.knockBack = 5f;
			item.value = 40000;
			item.rare = 3;
			item.noMelee = true;
			item.UseSound = SoundID.Item70;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 13.5f;
		}

		public override bool CanUseItem(Player player)
		{
			if (player.GetModPlayer<GlobalPlayer>().burstBuff)
			{
				item.useTime = 18;
				item.useAnimation = 18;
			}
			else
			{
				item.useTime = 27;
				item.useAnimation = 27;
			}
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("SteelArrowProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3504, 1);
			recipe.AddIngredient(99, 1);
			recipe.AddIngredient(3510, 1);
			recipe.AddIngredient(3516, 1);
			recipe.AddIngredient((Mod)null, "SteelBar", 5);
			recipe.AddIngredient((Mod)null, "ReinforcedString", 3);
			recipe.AddTile(16);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();

			ModRecipe recipe2 = new ModRecipe(mod);
			recipe2.AddIngredient(3498, 1);
			recipe2.AddIngredient(3492, 1);
			recipe2.AddIngredient(3486, 1);
			recipe2.AddIngredient(3480, 1);
			recipe2.AddIngredient((Mod)null, "SteelBar", 5);
			recipe2.AddIngredient((Mod)null, "ReinforcedString", 3);
			recipe2.AddTile(16);
			recipe2.SetResult(this, 1);
			recipe2.AddRecipe();
		}

		public MetalBow()
			
		{
		}
	}
}
