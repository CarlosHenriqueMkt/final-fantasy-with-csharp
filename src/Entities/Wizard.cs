using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalFantasy.src.Entities
{
    public abstract class Wizard(string name, string heroType, int level) : Hero(name, heroType, level)
    {
        public virtual string Attack(float damage)
        {
            return $"{Name} casts a basic spell dealing {damage} damage!";
        }
    }
}