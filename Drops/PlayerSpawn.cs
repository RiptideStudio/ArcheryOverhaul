using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;

namespace bowmod.Drops
{
	public class PlayerSpawn : ModPlayer
	{
		public override void SetupStartInventory(IList<Item> items)
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Expected O, but got Unknown
			Item recipe = new Item();
			recipe.SetDefaults(mod.ItemType("StarterBag"), false);
			items.Add(recipe);
		}

		public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
		{
			if (!junk && Main.LocalPlayer.ZoneBeach && liquidType == 0 && Main.rand.Next(30) == 0)
			{
				caughtType = mod.ItemType("FishBow");
			}
		}

		public PlayerSpawn()
			
		{
		}
	}
}
