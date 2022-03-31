using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace bowmod.World
{
	public class GlobalPlayer : ModPlayer
	{
		public bool summonSpiritMinion;

		public bool target;

		public bool loadBow = true;

		public bool sharpFlint;

		public bool largeArrow;
		public bool mysticQuiver = false;
		public bool burstBuff;
		public bool strangeQuiver = false;
		public bool target2;
		public bool homingSensor;

		public override void ResetEffects()
		{
			strangeQuiver = false;
			mysticQuiver = false;
			summonSpiritMinion = false;
			homingSensor = false;
			loadBow = true;
			sharpFlint = false;
			largeArrow = false;
			burstBuff = false;
			target = false;
			target2 = false;
		}

		public override void ModifyHitByProjectile(Projectile projectile, ref int damage, ref bool crit)
		{
			Player recipe = Main.player[projectile.owner];
			Vector2 center = projectile.Center;
			for (int i = 3; i < 8 + (Main.LocalPlayer.extraAccessorySlots); i++)
			{
				if (((Entity)recipe.armor[i]).width == 70)
				{
					float num = 5f;
					float num2 = 0f;
					float num3 = 3f;
					for (int j = 0; j < 6; j++)
					{
						Vector2 vector = Utils.RotatedByRandom(new Vector2(num, num2), (double)MathHelper.ToRadians(360f));
						num = vector.X;
						num2 = vector.Y;
						Projectile.NewProjectile(center.X, center.Y, num, num2, mod.ProjectileType("StoneProj"), 12, num3, ((Entity)recipe).whoAmI, 0f, 0f);
					}
				}
				if (((Entity)recipe.armor[i]).width == 71)
				{
					float num4 = 5f;
					float num5 = 0f;
					float num6 = 3f;
					for (int k = 0; k < 6; k++)
					{
						Vector2 vector2 = Utils.RotatedByRandom(new Vector2(num4, num5), (double)MathHelper.ToRadians(360f));
						num4 = vector2.X;
						num5 = vector2.Y;
						Projectile.NewProjectile(center.X, center.Y, num4, num5, 2, 22, num6, ((Entity)recipe).whoAmI, 0f, 0f);
					}
				}
				if (recipe.armor[i].value == 72)
				{
					float num7 = 5f;
					float num8 = 0f;
					float num9 = 3f;
					for (int l = 0; l < 6; l++)
					{
						Vector2 vector3 = Utils.RotatedByRandom(new Vector2(num7, num8), (double)MathHelper.ToRadians(360f));
						num7 = vector3.X;
						num8 = vector3.Y;
						Projectile.NewProjectile(center.X, center.Y, num7, num8, mod.ProjectileType("SurgeProj"), 12, num9, ((Entity)recipe).whoAmI, 0f, 0f);
					}
				}
				if (((Entity)recipe.armor[i]).width == 61)
				{
					float num10 = 5f;
					float num11 = 0f;
					float num12 = 3f;
					for (int m = 0; m < 6; m++)
					{
						Vector2 vector4 = Utils.RotatedByRandom(new Vector2(num10, num11), (double)MathHelper.ToRadians(360f));
						num10 = vector4.X;
						num11 = vector4.Y;
						Projectile.NewProjectile(center.X, center.Y, num10, num11, mod.ProjectileType("ElectricProj"), 20, num12, ((Entity)recipe).whoAmI, 0f, 0f);
					}
				}
				if (((Entity)recipe.armor[i]).width == 101)
				{
					float num13 = 5f;
					float num14 = 0f;
					float num15 = 3f;
					for (int n = 0; n < 6; n++)
					{
						Vector2 vector5 = Utils.RotatedByRandom(new Vector2(num13, num14), (double)MathHelper.ToRadians(360f));
						num13 = vector5.X;
						num14 = vector5.Y;
						Projectile.NewProjectile(center.X, center.Y, num13, num14, mod.ProjectileType("ElectricProj"), 24, num15, ((Entity)recipe).whoAmI, 0f, 0f);
						Projectile.NewProjectile(center.X, center.Y, num13, num14, mod.ProjectileType("SurgeProj"), 24, num15, ((Entity)recipe).whoAmI, 0f, 0f);
						Projectile.NewProjectile(center.X, center.Y, num13, num14, mod.ProjectileType("StoneProj"), 24, num15, ((Entity)recipe).whoAmI, 0f, 0f);
						Projectile.NewProjectile(center.X, center.Y, num13, num14, 2, 24, num15, ((Entity)recipe).whoAmI, 0f, 0f);
					}
				}
			}
		}

		public override void ModifyHitByNPC(NPC npc, ref int damage, ref bool crit)
		{
			Projectile recipe = Main.projectile[0];
			Player val2 = Main.player[recipe.owner];
			for (int i = 3; i < 8 + (Main.LocalPlayer.extraAccessorySlots); i++)
			{
				if (((Entity)val2.armor[i]).width == 101)
				{
					Vector2 center = Main.LocalPlayer.Center;
					float num = 3f;
					float num2 = 0f;
					float num3 = 6f;
					for (int j = 0; j < 6; j++)
					{
						Vector2 vector = Utils.RotatedByRandom(new Vector2(num, num2), (double)MathHelper.ToRadians(360f));
						num = vector.X;
						num2 = vector.Y;
						Projectile.NewProjectile(center.X, center.Y, num, num2, mod.ProjectileType("ElectricProj"), 24, num3, ((Entity)val2).whoAmI, 0f, 0f);
						Projectile.NewProjectile(center.X, center.Y, num, num2, mod.ProjectileType("SurgeProj"), 24, num3, ((Entity)val2).whoAmI, 0f, 0f);
						Projectile.NewProjectile(center.X, center.Y, num, num2, mod.ProjectileType("StoneProj"), 24, num3, ((Entity)val2).whoAmI, 0f, 0f);
						Projectile.NewProjectile(center.X, center.Y, num, num2, 2, 24, num3, ((Entity)val2).whoAmI, 0f, 0f);
					}
					val2.ghostFrameCounter = 0;
				}
				if (((Entity)val2.armor[i]).width == 70)
				{
					Vector2 center2 = Main.LocalPlayer.Center;
					float num4 = 3f;
					float num5 = 0f;
					float num6 = 6f;
					for (int k = 0; k < 6; k++)
					{
						Vector2 vector2 = Utils.RotatedByRandom(new Vector2(num4, num5), (double)MathHelper.ToRadians(360f));
						num4 = vector2.X;
						num5 = vector2.Y;
						Projectile.NewProjectile(center2.X, center2.Y, num4, num5, mod.ProjectileType("StoneProj"), 12, num6, ((Entity)val2).whoAmI, 0f, 0f);
					}
					val2.ghostFrameCounter = 0;
				}
				if (((Entity)val2.armor[i]).width == 71)
				{
					Vector2 center3 = Main.LocalPlayer.Center;
					float num7 = 3f;
					float num8 = 0f;
					float num9 = 6f;
					for (int l = 0; l < 6; l++)
					{
						Vector2 vector3 = Utils.RotatedByRandom(new Vector2(num7, num8), (double)MathHelper.ToRadians(360f));
						num7 = vector3.X;
						num8 = vector3.Y;
						Projectile.NewProjectile(center3.X, center3.Y, num7, num8, 2, 22, num9, ((Entity)val2).whoAmI, 0f, 0f);
					}
					val2.ghostFrameCounter = 0;
				}
				if (val2.armor[i].value == 100011)
				{
					Vector2 center4 = Main.LocalPlayer.Center;
					float num10 = 3f;
					float num11 = 0f;
					float num12 = 6f;
					for (int m = 0; m < 6; m++)
					{
						Vector2 vector4 = Utils.RotatedByRandom(new Vector2(num10, num11), (double)MathHelper.ToRadians(360f));
						num10 = vector4.X;
						num11 = vector4.Y;
						Projectile.NewProjectile(center4.X, center4.Y, num10, num11, mod.ProjectileType("SurgeProj"), 12, num12, ((Entity)val2).whoAmI, 0f, 0f);
					}
					val2.ghostFrameCounter = 0;
				}
				if (((Entity)val2.armor[i]).width == 69)
				{
					Vector2 center5 = Main.LocalPlayer.Center;
					float num13 = 3f;
					float num14 = 0f;
					float num15 = 6f;
					for (int n = 0; n < 6; n++)
					{
						Vector2 vector5 = Utils.RotatedByRandom(new Vector2(num13, num14), (double)MathHelper.ToRadians(360f));
						num13 = vector5.X;
						num14 = vector5.Y;
						Projectile.NewProjectile(center5.X, center5.Y, num13, num14, mod.ProjectileType("ElectricProj"), 20, num15, ((Entity)val2).whoAmI, 0f, 0f);
					}
					val2.ghostFrameCounter = 0;
				}
			}
		}

		public GlobalPlayer()
			
		{
		}
	}
}
