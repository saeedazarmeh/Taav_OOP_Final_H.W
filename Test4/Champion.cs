using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    public class Champion : Character
    {
        public Champion(int health, int power, int speed, string name) : base(health, power, name)
        {
        }
        public int Speed { get; set; }

        public override void ShowCharacter()
        {
            Console.WriteLine($"ChampionId{Id} Name:{Name} Power:{Power} Health:{Health} Speed:{Speed}");
        }

        public override void UnderAttacked(int power)
        {
            Health -= power / 10;
            if (Health <= 0)
            {
                AliveState = AliveState.Dead;
                Console.WriteLine("You Losed");

            }
            else
            {
                Console.WriteLine($"{Name} Health is {Health}");
            }
        }

    }
}
