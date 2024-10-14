using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalFantasy.src.Entities
{
    public class Ninja(string name, string heroType, int level) : Hero(name, heroType, level)
    {
        public string Attack(float damage)
        {
            return $"{Name} strikes with a kodachi and deals {damage} of damage in the target";
        }

        public string Ninjutsu()
        {
            return $"{Name} uses Ninjutsu that permits to evade every damage and deals 12 of damage for two rounds";
        }
    }
}
