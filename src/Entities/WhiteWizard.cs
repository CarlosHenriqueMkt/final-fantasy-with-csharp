using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalFantasy.src.Entities
{
    public class WhiteWizard(string name, string heroType, int level) : Wizard(name, heroType, level)
    {
        public override string Attack(float damage)
        {
            return $"{Name} casts Holy Light, dealing {damage} damage to the target.";
        }

        public string HighHeal()
        {
            return $"{Name} casts a powerful healing spell, restoring health to the party.";
        }
    }
}
