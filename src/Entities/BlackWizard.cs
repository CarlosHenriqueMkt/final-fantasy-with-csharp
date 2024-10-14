using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalFantasy.src.Entities
{
    public class BlackWizard(string name, string heroType, int level) : Wizard(name, heroType, level)
    {
        public override string Attack(float damage)
        {
            return $"{Name} casts Fireball, dealing {damage} damage to all the enemies.";
        }
        public string BlackHole(float damage)
        {
            return $"{Name} casts Dark Magic, draining {damage} life from enemies and restoring their own health.";
        }
    }
}
