using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class RainBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Rain-bow\n-= Donor Item =-");
			Tooltip.SetDefault("'It's a rain-bow! What does it mean?!'\nShoots a burst of arrows\nThe third arrow is a rainbow arrow and leaves behind a long-lasting rainbow trail\nThis weapon is definitely a liability");
		}

		public override void SetDefaults()
		{
			item.damage = 30;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 10;
			item.useAnimation = 30;
			item.reuseDelay = 32;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 100000;
			item.rare = -12;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 12f;
			item.crit = 40;
		}

		public override bool ConsumeAmmo(Player player)
		{
			Main.PlaySound(SoundID.Item5, -1, -1);
			return player.itemAnimation >= item.useAnimation - 2;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			if (player.itemAnimation <= 10)
			{
				type = mod.ProjectileType("RainbowProj");
				Projectile.NewProjectile(position.X, position.Y, speedX, speedY, 250, damage, knockback, ((Entity)player).whoAmI, 0f, 0f);
			}
			return true;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(4f, 0f);
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
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(391, 15);
			recipe.AddIngredient(520, 10);
			recipe.AddIngredient(662, 25);
			recipe.AddIngredient((Mod)null, "MysticString", 1);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			ModRecipe val2 = new ModRecipe(mod);
			val2.AddIngredient(1198, 15);
			val2.AddIngredient(520, 10);
			val2.AddIngredient(662, 25);
			val2.AddIngredient((Mod)null, "MysticString", 1);
			val2.AddTile(134);
			val2.SetResult(this, 1);
			val2.AddRecipe();
		}

		public RainBow()
			
		{
		}
	}
}
