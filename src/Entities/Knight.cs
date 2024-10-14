using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalFantasy.src.Entities
{
    public class Knight(string name, string heroType, int level) : Hero(name, heroType, level)
    {
        public string Attack(float damage)
        {
            return $"{Name} strikes with a sword and deals {damage} of damage in the target";
        }
    }
}
