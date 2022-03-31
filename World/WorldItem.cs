using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.ModLoader.IO;
using Terraria.Utilities;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.World
{
	public class WorldItem : GlobalItem
	{
		public float awesome;

		internal int index;

		internal int instanceIndex;

		public bowmod mod { get; internal set; }

		public string Name { get; internal set; }

		public override bool InstancePerEntity => true;

		public override bool CloneNewInstances => true;

		public virtual bool Autoload(ref string name)
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return mod.Properties.Autoload;
		}

		public override void SetDefaults(Item item)
		{
			if (item.ranged)
			{
				item.autoReuse = true;
			}
		}
		public override bool Shoot(Item item, Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Player recipe = Main.player[Main.myPlayer];
			if (recipe.GetModPlayer<GlobalPlayer>().target && item.ranged)
            {
				speedX += (speedX * 0.12f);
				speedY += (speedY * 0.12f);
			}
		
			if (recipe.GetModPlayer<GlobalPlayer>().strangeQuiver)
			{
				if (!Main.hardMode && type == 1)
				{
					int num = Main.rand.Next(5);
					if (num == 0)
					{
						type = 474;
					}
					if (num == 1)
					{
						type = 2;
					}
					if (num == 2)
					{
						type = 172;
					}
					if (num == 3)
					{
						type = 4;
					}
					if (num == 4)
					{
						type = 5;
					}
				}
				if (Main.hardMode && type == 1)
				{
					int num2 = Main.rand.Next(8);
					if (num2 == 0)
					{
						type = 278;
					}
					if (num2 == 1)
					{
						type = 2;
					}
					if (num2 == 2)
					{
						type = 172;
					}
					if (num2 == 3)
					{
						type = 4;
					}
					if (num2 == 4)
					{
						type = 5;
					}
					if (num2 == 5)
					{
						type = 91;
					}
					if (num2 == 6)
					{
						type = 103;
					}
					if (num2 == 7)
					{
						type = 278;
					}
				}
			}
			if (item.ranged && player.GetModPlayer<GlobalPlayer>().target == false)
			{ 
				int slowChance = Main.rand.Next(1, 4);
				//Make some arrows slower than others
				if (slowChance == 3)
				{
					float speedReduce = Main.rand.NextFloat(0.75f, 0.85f);
					speedX *= speedReduce;
					speedY *= speedReduce;
				}
			}

			return true;
		}
		public WorldItem()
			
		{
		}
	}
}
