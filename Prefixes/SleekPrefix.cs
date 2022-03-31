using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Prefixes
{
	public class SleekPrefix : ModPrefix
	{
		private readonly byte _power;

		public override PrefixCategory Category => (PrefixCategory)1;

		public override float RollChance(Item item)
		{
			return 5f;
		}

		public override bool CanRoll(Item item)
		{
			return true;
		}

		public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
		{
			damageMult += 0.05f;
			critBonus += 2;
			shootSpeedMult += 0.15f;
		}

		public override bool Autoload(ref string name)
		{
			if (!base.Autoload(ref name))
			{
				return false;
			}
			mod.AddPrefix("Sleek", (ModPrefix)(object)new SleekPrefix());
			return false;
		}

		public override void Apply(Item item)
		{
			item.GetGlobalItem<WorldItem>().awesome = (int)_power;
		}

		public override void ModifyValue(ref float valueMult)
		{
			_ = _power;
			valueMult = 1.25f;
		}

		public SleekPrefix()
			
		{
		}
	}
}
