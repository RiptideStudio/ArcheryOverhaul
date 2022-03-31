using System.Collections.Generic;
using System;
using Terraria;
using System.Diagnostics;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Materials
{
	public class ReinforcedString : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Silver String");
			Tooltip.SetDefault("Used to make strong bows");
			Main.RegisterItemAnimation(item.type, new DrawAnimationVertical(6, 16));
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 52;
			item.maxStack = 999;
			item.value = 1000;
			item.rare = 2;
		}

		public override void AddRecipes()
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0029: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_005a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient((Mod)null, "String", 1);
			recipe.AddIngredient(21, 1);
			recipe.AddTile(86);
			recipe.SetResult(this, 1);
			recipe.AddRecipe();
			ModRecipe val2 = new ModRecipe(mod);
			val2.AddIngredient((Mod)null, "String", 1);
			val2.AddIngredient(705, 1);
			val2.AddTile(86);
			val2.SetResult(this, 1);
			val2.AddRecipe();
		}

		public ReinforcedString()
			
		{
		}
	}
}
