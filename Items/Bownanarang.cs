using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace bowmod.Items
{
	public class Bownanarang : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("The Bownanarang");
			Tooltip.SetDefault("'God has left the chat'\nUnleashes a fury of arrows\nStacks up to five times");
		}

		public override void SetDefaults()
		{
			item.damage = 55;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.maxStack = 5;
			item.knockBack = 2f;
			item.value = 5000;
			item.rare = 7;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shootSpeed = 15f;
			item.noUseGraphic = true;
			item.shoot = 1;
		}

		public override bool CanUseItem(Player player)
		{
			for (int i = 0; i < 1000; i++)
			{
				if (player.ownedProjectileCounts[mod.ProjectileType("BownanarangProj")] >= item.stack)
				{
					return false;
				}
			}
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			Projectile.NewProjectile(position.X, position.Y, speedX, speedY, mod.ProjectileType("BownanarangProj"), damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			return false;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(null,"BoomerangBow", 1);
			recipe.AddIngredient(null,"DwarfAlloy", 2);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public Bownanarang()

		{
		}
	}
}
