using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.World
{
	public class GlobalProj : GlobalProjectile
	{

		public override void Kill(Projectile projectile, int timeLeft)
		{
			Player recipe = Main.player[projectile.owner];
			if (recipe.GetModPlayer<GlobalPlayer>().sharpFlint && projectile.arrow)
			{
				Main.rand.Next(3, 5);
				Vector2 center = projectile.Center;
				float num = 5f;
				float num2 = 0f;
				for (int i = 0; i < 3; i++)
				{
					Vector2 vector = Utils.RotatedByRandom(new Vector2(num, num2), (double)MathHelper.ToRadians(360f));
					num = vector.X;
					num2 = vector.Y;
					Projectile.NewProjectile(center.X, center.Y, num / 2f, num2 / 2f, mod.ProjectileType("FlintShrapnel"), projectile.damage / 10, 0f, ((Entity)recipe).whoAmI, 0f, 0f);
				}
			}
		}

		public override void PostAI(Projectile projectile)
		{
			if (projectile.arrow)
			{
				_ = Main.player[projectile.owner];
				for (int num = projectile.oldPos.Length - 1; num > 0; num--)
				{
					projectile.oldPos[num] = projectile.oldPos[num - 1];
				}
			}
			projectile.oldPos[0] = ((Entity)projectile).position;
		}

		public override void PostDraw(Projectile projectile, SpriteBatch spriteBatch, Color lightColor)
		{
			float num = 25f;
			float num2 = 15f;
		}

		public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit)
		{

			damage -= Main.rand.Next(0, 3);
			Player recipe = Main.player[projectile.owner];

			if (Main.rand.Next(0, 7) == 2)
			{
				if (recipe.GetModPlayer<GlobalPlayer>().mysticQuiver && projectile.type != mod.ProjectileType("MagicProj") && projectile.ranged)
				{
					int num3 = 12;
					int num2 = 16;
					Projectile.NewProjectile(((Entity)recipe).position.X + (float)num3, ((Entity)recipe).position.Y + (float)num2, 5f, 0f, mod.ProjectileType("MagicProj"), 32, 0f, ((Entity)recipe).whoAmI, 30f, 2f);
					Projectile.NewProjectile(((Entity)recipe).position.X + (float)num3, ((Entity)recipe).position.Y + (float)num2, -5f, 0f, mod.ProjectileType("MagicProj"), 32, 0f, ((Entity)recipe).whoAmI, 30f, 2f);
					Projectile.NewProjectile(((Entity)recipe).position.X + (float)num3, ((Entity)recipe).position.Y + (float)num2, 0f, 5f, mod.ProjectileType("MagicProj"), 32, 0f, ((Entity)recipe).whoAmI, 30f, 2f);
					Projectile.NewProjectile(((Entity)recipe).position.X + (float)num3, ((Entity)recipe).position.Y + (float)num2, 0f, -5f, mod.ProjectileType("MagicProj"), 32, 0f, ((Entity)recipe).whoAmI, 30f, 2f);
				}
			}

			if (projectile.ranged)
			{
				Projectile.NewProjectile(((Entity)projectile).position.X, ((Entity)projectile).position.Y, 0f, 0f, mod.ProjectileType("HitEffect_1"), 0, 0f, ((Entity)recipe).whoAmI, 0f, 0f);
			}
			Vector2 center = projectile.Center;

			if (crit && projectile.arrow)
			{
				Projectile.NewProjectile(((Entity)target).position.X + 16f, ((Entity)target).position.Y + 16f, 0f, 0f, mod.ProjectileType("Crit_Effect_1"), projectile.damage / 3, 0f, ((Entity)recipe).whoAmI, 0f, 0f);
			}
		}

		public override bool OnTileCollide(Projectile projectile, Vector2 oldVelocity)
		{
			if (projectile.arrow)
			{
				_ = projectile.type;
				int num = Main.rand.Next(0, 3);
				if (num == 2)
				{
					if (projectile.type == mod.ProjectileType("PoisonProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("PoisonArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("SteelArrowProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("SteelArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("MarbleProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("MarbleArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("GraniteProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("GraniteArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("FreezeflameProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("FreezeflameArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("SandProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("SandArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("SandStoneProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("SandArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("DemonProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("DemonArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("CrimsonProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("CrimsonArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("PearlProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("PearlArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("CrystalProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("CrystalArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("BlizzardProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("BlizzardArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("AlloyProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("AlloyArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("ExplosiveProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("ExplosiveArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("SandstormArrowProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("SandstormArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("SkyProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("SkyArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("SnowProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("SnowArrow"), 1, false, 0, false, false);
					}
					if (projectile.type == mod.ProjectileType("StoneProj"))
					{
						Item.NewItem((int)((Entity)projectile).position.X, (int)((Entity)projectile).position.Y, ((Entity)projectile).width, ((Entity)projectile).height, mod.ItemType("StoneArrow"), 1, false, 0, false, false);
					}
				}
				_ = Main.player[projectile.owner];
				Vector2 vector = (((Entity)projectile).position = new Vector2(((Entity)projectile).position.X, ((Entity)projectile).position.Y - 2f));
				if (projectile.type == 1)
				{
					Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/WoodenArrowGore1"), 1f);
					Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/WoodenArrowGore2"), 1f);
				}
				if (projectile.type == 2)
				{
					Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/FireArrowGore1"), 1f);
					Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/FireArrowGore2"), 1f);
				}
				if (projectile.type == 172)
				{
					Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/FrostArrowGore1"), 1f);
					Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/FrostArrowGore2"), 1f);
				}
				if (projectile.type == 4)
				{
					Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/UnholyArrowGore1"), 1f);
					Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/UnholyArrowGore2"), 1f);
				}
				if (projectile.type == 5)
				{
					Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/JesterArrowGore1"), 1f);
					Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/JesterArrowGore2"), 1f);
				}
				if (projectile.type == 474)
				{
					Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/BoneArrowGore1"), 1f);
					Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/BoneArrowGore2"), 1f);
				}
				if (num != 2)
				{
					if (projectile.type == mod.ProjectileType("GraniteProj"))
					{
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/GraniteArrowGore1"), 1f);
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/GraniteArrowGore2"), 1f);
					}
					if (projectile.type == mod.ProjectileType("SandStoneProj"))
					{
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/SandArrowGore1"), 1f);
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/SandArrowGore2"), 1f);
					}
					if (projectile.type == mod.ProjectileType("SteelArrowProj"))
					{
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/SteelArrowGore1"), 1f);
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/SteelArrowGore2"), 1f);
					}
					if (projectile.type == mod.ProjectileType("BlizzardProj"))
					{
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/BlizzardArrowGore1"), 1f);
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/BlizzardArrowGore2"), 1f);
					}
					if (projectile.type == mod.ProjectileType("CrimsonProj"))
					{
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/CrimsonArrowGore1"), 1f);
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/CrimsonArrowGore2"), 1f);
					}
					if (projectile.type == mod.ProjectileType("DemonProj"))
					{
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/DemonArrowGore1"), 1f);
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/DemonArrowGore2"), 1f);
					}
					if (projectile.type == mod.ProjectileType("PoisonProj"))
					{
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/PoisonProjGore1"), 1f);
						Gore.NewGore(((Entity)projectile).position, ((Entity)projectile).velocity, mod.GetGoreSlot("Gores/PoisonProjGore2"), 1f);
					}
				}
			}
			return true;
		}

		public override void SetDefaults(Projectile projectile)
		{
			Player recipe = Main.player[Main.myPlayer];
			if (recipe.ghostFade == 3f)
			{
				if (projectile.arrow)
				{
					projectile.scale += 0.15f;
				}
				recipe.ghostFade = 0f;
			}
			if (projectile.arrow)
			{
				float num = Utils.NextFloat(Main.rand, -0.05f, 0.05f);
				float num2 = Utils.NextFloat(Main.rand, -0.05f, 0.05f);
				projectile.scale += num;
				projectile.damage += (int)((float)projectile.damage * num2);
			}


			if (recipe.ghostFade == 2f)
			{
				projectile.penetrate++;
				if (projectile.penetrate == 0)
				{
					projectile.penetrate--;
				}
				recipe.ghostFade = 0f;
			}

			if (recipe.ghostFrame == 100)
			{
				_ = projectile.type;
				_ = 1;
				recipe.ghostFrame = 0;
			}
		}
		
		public override void AI(Projectile projectile)
		{
			Player recipe = Main.LocalPlayer;

			if (recipe.GetModPlayer<GlobalPlayer>().homingSensor && projectile.arrow)
            {

				if (projectile.localAI[0] == 0f)
				{
					AdjustMagnitude(ref ((Entity)projectile).velocity);
					projectile.localAI[0] = 1f;
				}
				Vector2 vector = Vector2.Zero;
				float num3 = 400f;
				bool flag = false;
				for (int i = 0; i < 200; i++)
				{
					if (((Entity)Main.npc[i]).active && !Main.npc[i].dontTakeDamage && !Main.npc[i].friendly && Main.npc[i].lifeMax > 5)
					{
						Vector2 vector2 = Main.npc[i].Center - projectile.Center;
						float num4 = (float)Math.Sqrt(vector2.X * vector2.X + vector2.Y * vector2.Y);
						if (num4 < num3)
						{
							vector = vector2;
							num3 = num4;
							flag = true;
						}
					}
				}
				if (flag)
				{
					AdjustMagnitude(ref vector);
					((Entity)projectile).velocity = (20f * ((Entity)projectile).velocity + vector) / 2f;
					AdjustMagnitude(ref ((Entity)projectile).velocity);
				}
			}

		}

		private void AdjustMagnitude(ref Vector2 vector)
		{
			Projectile recipe = Main.projectile[0];
			Player val2 = Main.LocalPlayer;
			if (val2.GetModPlayer<GlobalPlayer>().homingSensor)
            {
				for (int i = 3; i < 8 + val2.extraAccessorySlots; i++)
				{
					if (val2.GetModPlayer<GlobalPlayer>().homingSensor)
					{
						float num = (float)Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y);
						if (num > 10.5f)
						{
							vector *= 10.5f / num;
						}
					}
				}
			}

		}

		public GlobalProj()
			
		{
		}
	}
}
