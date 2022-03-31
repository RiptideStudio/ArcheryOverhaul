using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Prefixes
{
	public class StrainedPrefix : ModPrefix
	{
		private readonly byte _power;

		public override PrefixCategory Category => (PrefixCategory)1;

		public override float RollChance(Item item)
		{
			return 4f;
		}

		public override bool CanRoll(Item item)
		{
			return true;
		}

		public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
		{
			damageMult += 0.1f;
			useTimeMult += 0.1f;
		}

		public override bool Autoload(ref string name)
		{
			if (!base.Autoload(ref name))
			{
				return false;
			}
			mod.AddPrefix("Strained", (ModPrefix)(object)new StrainedPrefix());
			return false;
		}

		public override void Apply(Item item)
		{
			item.GetGlobalItem<WorldItem>().awesome = (int)_power;
		}

		public override void ModifyValue(ref float valueMult)
		{
			_ = _power;
		}

		public StrainedPrefix()
			
		{
		}
	}
}
