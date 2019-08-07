using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musteria
{
    class LiCre
    {
        int maxHealth;
        int health;
        int power;

        public int Health { get => health; set => health = value; }
        public int Power { get => power; set => power = value; }
        public int MaxHealth { get => maxHealth; set => maxHealth = value; }

        public LiCre(int MaxHealth,int Power)
        {
            maxHealth = MaxHealth;
            health = MaxHealth;
            power = Power;
        }
    }
}
