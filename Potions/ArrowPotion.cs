using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Potions
{
	public class ArrowPotion : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lesser Archery Potion");
			Tooltip.SetDefault("Increases arrow damage by 10%");
		}

		public override void SetDefaults()
		{
			item.width = 16;
			item.height = 32;
			item.useTime = 17;
			item.useTurn = true;
			item.useAnimation = 17;
			item.useStyle = 2;
			item.value = 100;
			item.maxStack = 30;
			item.rare = 1;
			item.UseSound = SoundID.Item3;
			item.autoReuse = true;
			item.consumable = true;
			item.buffTime = 16200;
			item.buffType = mod.BuffType("ArrowBuff");
		}

		public ArrowPotion()
			
		{
		}
	}
}
