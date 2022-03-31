using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace bowmod.Items
{
	public class StrangeBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Strange Bow");
			Tooltip.SetDefault("Does random damage\nBecomes more powerful as time progresses");
		}

		public override void SetDefaults()
		{
			item.damage = 1;
			item.ranged = true;
			item.width = 36;
			item.height = 52;
			item.useTime = 23;
			item.useAnimation = 23;
			item.useStyle = 5;
			item.knockBack = 3f;
			item.value = 400000;
			item.rare = -12;
			item.noMelee = true;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = 1;
			item.shootSpeed = 9f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockback)
		{
			int damage2 = Main.rand.Next(40);
			if (Main.hardMode)
			{
				damage2 = Main.rand.Next(75);
				item.useTime = 20;
				item.useAnimation = 20;
				item.rare = -12;
				if (NPC.downedMechBossAny)
				{
					damage2 = Main.rand.Next(125);
					item.useTime = 17;
					item.useAnimation = 17;
					item.rare = -12;
				}
				if (NPC.downedPlantBoss)
				{
					damage2 = Main.rand.Next(150);
					item.useTime = 22;
					item.useAnimation = 22;
					item.rare = -12;
				}
			}
			item.damage = damage2;
			item.rare = -12;
			return true;
		}

		public StrangeBow()
			
		{
		}
	}
}
