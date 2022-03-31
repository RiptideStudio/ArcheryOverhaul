using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops.World
{
	public class ChestSpawn : ModWorld
	{
		public override void PostWorldGen()
		{
			int[] array = new int[1] { mod.ItemType("ArrowBag") };
			int[] array2 = new int[1] { mod.ItemType("Grenade1") };
			int num = 0;
			for (int i = 0; i < 1000; i++)
			{
				Chest recipe = Main.chest[i];
				if (recipe == null || Main.tile[recipe.x, recipe.y].type != 21 || Main.tile[recipe.x, recipe.y].frameX != 0)
				{
					continue;
				}
				for (int j = 0; j < 40; j++)
				{
					if (recipe.item[j].type == 0)
					{
						recipe.item[j].SetDefaults(array[num], false);
						num = (num + 1) % array.Length;
						j++;
						recipe.item[j].SetDefaults(array2[num], false);
						num = (num + 1) % array2.Length;
						break;
					}
				}
			}
			for (int k = 0; k < 1000; k++)
			{
				Chest val2 = Main.chest[k];
				int[] array3 = new int[1] { mod.ItemType("IceBag") };
				if (val2 == null || Main.tile[val2.x, val2.y].type != 21 || Main.tile[val2.x, val2.y].frameX != 396)
				{
					continue;
				}
				for (int l = 0; l < 40; l++)
				{
					if (val2.item[l].type == 0)
					{
						val2.item[l].SetDefaults(array3[num], false);
						num = (num + 1) % array3.Length;
						l++;
						break;
					}
				}
			}
			for (int m = 0; m < 1000; m++)
			{
				Chest val3 = Main.chest[m];
				int[] array4 = new int[1] { mod.ItemType("JungleBag") };
				if (val3 == null || Main.tile[val3.x, val3.y].type != 21 || Main.tile[val3.x, val3.y].frameX != 360)
				{
					continue;
				}
				for (int n = 0; n < 40; n++)
				{
					if (val3.item[n].type == 0)
					{
						val3.item[n].SetDefaults(array4[num], false);
						num = (num + 1) % array4.Length;
						n++;
						break;
					}
				}
			}
			for (int num2 = 0; num2 < 1000; num2++)
			{
				Chest val4 = Main.chest[num2];
				int[] array5 = new int[1] { mod.ItemType("JungleBag") };
				if (val4 == null || Main.tile[val4.x, val4.y].type != 21 || Main.tile[val4.x, val4.y].frameX != 288)
				{
					continue;
				}
				for (int num3 = 0; num3 < 40; num3++)
				{
					if (val4.item[num3].type == 0)
					{
						val4.item[num3].SetDefaults(array5[num], false);
						num = (num + 1) % array5.Length;
						num3++;
						break;
					}
				}
			}
			for (int num4 = 0; num4 < 1000; num4++)
			{
				Chest val5 = Main.chest[num4];
				int[] array6 = new int[1] { mod.ItemType("ApolloStaff") };
				if (val5 == null || Main.tile[val5.x, val5.y].type != 21 || Main.tile[val5.x, val5.y].frameX != 36)
				{
					continue;
				}
				for (int num5 = 0; num5 < 40; num5++)
				{
					if (val5.item[num5].type == 0)
					{
						if (Main.rand.Next(4) == 0)
						{
							val5.item[num5].SetDefaults(array6[num], false);
						}
						num = (num + 1) % array6.Length;
						num5++;
						break;
					}
				}
			}
		}

		public ChestSpawn()
			
		{
		}
	}
}
