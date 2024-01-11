using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    public class Enemy : Character
    {
        public Enemy(int health, int power, string name) : base(health, power, name)
        {
        }

        public override void ShowCharacter()
        {
            Console.WriteLine($"ChampionId{Id} Name:{Name} Power:{Power} Health:{Health}");
        }

        public override void UnderAttacked(int power)
        {
            Health -= power / 10;
            if (Health <= 0)
            {
                AliveState = AliveState.Dead;
                Console.WriteLine("You Win");
            }
            else
            {
                Console.WriteLine($"{Name} Health is {Health}");
            }
        }
    }
}
