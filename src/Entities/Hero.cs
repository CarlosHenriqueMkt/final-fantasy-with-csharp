using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalFantasy.src.Entities
{
    public abstract class Hero(string name, string heroType, int level)
    {
        public string Name { get; set; } = name;
        public string HeroType { get; set; } = heroType;
        public int Level { get; set; } = level;

        public override string ToString()
        {
            return $"{Name} {HeroType} {Level}";
        }
    }
}
