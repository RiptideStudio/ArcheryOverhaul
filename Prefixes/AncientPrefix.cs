using Terraria;
using Terraria.ModLoader;
using bowmod.World;

namespace bowmod.Prefixes
{
	public class AncientPrefix : ModPrefix
	{
		private readonly byte _power;

		public override PrefixCategory Category => (PrefixCategory)1;

		public override float RollChance(Item item)
		{
			return 1.5f;
		}

		public override bool CanRoll(Item item)
		{
			return true;
		}

		public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
		{
			critBonus += 7;
			damageMult += 0.15f;
			shootSpeedMult += 0.12f;
			knockbackMult += 0.08f;
			useTimeMult -= 0.12f;
		}

		public override bool Autoload(ref string name)
		{
			if (!base.Autoload(ref name))
			{
				return false;
			}
			mod.AddPrefix("Ancient", (ModPrefix)(object)new AncientPrefix());
			return false;
		}

		public override void Apply(Item item)
		{
			item.GetGlobalItem<WorldItem>().awesome = (int)_power;
		}

		public override void ModifyValue(ref float valueMult)
		{
			_ = _power;
			valueMult = 1.5f;
		}

		public AncientPrefix()
			
		{
		}
	}
}
