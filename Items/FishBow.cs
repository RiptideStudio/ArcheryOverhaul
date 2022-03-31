using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.UI.Chat;

namespace bowmod.Items
{
	public class FishBow : ModItem
	{
		private Vector2 boxSize;

		private const int paddingForBox = 16;

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Trout Spout");
			Tooltip.SetDefault("Can you believe this item exists?\nTurns wooden arrows into a trout with an evil agenda");
		}

		public override void SetDefaults()
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 27;
			item.useAnimation = 27;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 100000;
			item.rare = 2;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 9.5f;
		}

		public override bool PreDrawTooltip(ReadOnlyCollection<TooltipLine> lines, ref int x, ref int y)
		{
			IEnumerable<string> source = lines.Select((TooltipLine z) => z.text);
			int num = source.Max((string t) => (int)ChatManager.GetStringSize(Main.fontMouseText, t, Vector2.One, -1f).X) + 16;
			int num2 = (int)source.ToList().Sum((string z) => Main.fontMouseText.MeasureString(z).Y) + 16;
			boxSize = new Vector2(num, num2);
			return true;
		}

		public override bool PreDrawTooltipLine(DrawableTooltipLine line, ref int yOffset)
		{
			if (!line.oneDropLogo)
			{
				string text = "-= Donor Item =-";
				float y = line.font.MeasureString(text).Y;
				if (((TooltipLine)line).Name == "ItemName" && ((TooltipLine)line).mod == "Terraria")
				{
					_ = boxSize.X / 3f;
					float x = line.X;
					float y2 = (float)line.Y + y / 1f;
					ChatManager.DrawColorCodedStringWithShadow(Main.spriteBatch, line.font, text, new Vector2(x, y2), line.color, line.rotation, line.origin, line.baseScale, line.maxWidth, line.spread);
					yOffset = (int)y;
				}
				else
				{
					yOffset = 0;
				}
			}
			return true;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			if (type == 1)
			{
				type = mod.ProjectileType("FishProj");
			}
			return true;
		}

		public FishBow()
			
		{
		}
	}
}
