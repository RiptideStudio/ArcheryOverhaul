using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Accessories
{
	[AutoloadEquip(EquipType.Back)]
	public class MysticQuiver : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Mystic Quiver");
			Tooltip.SetDefault("'Archery magic lies on your shoulder'\n10% Increased arrow damage and critical strike chance\n20% Chance not to consume arrows\nWhen an arrow hits an enemy, arrows may be magically created");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.rare = 5;
			item.value = 70000;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.rangedDamage += 0.1f;
			player.rangedCrit += 10;
			player.ammoBox = true;
			player.GetModPlayer<GlobalPlayer>().mysticQuiver = true;
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
			recipe.AddIngredient((Mod)null, "Quiver", 1);
			recipe.AddIngredient(621, 20);
			recipe.AddIngredient(520, 10);
			recipe.AddIngredient((Mod)null, "MysticShard", 5);
			recipe.AddTile(134);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
		}

		public MysticQuiver()
			
		{
		}
	}
}
