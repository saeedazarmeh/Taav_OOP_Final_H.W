using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    public abstract class Character
    {
        internal static List<Character> characters=new List<Character>();

        protected Character(int health, int power, string name)
        {
            Health = health;
            Power = power;
            Name = name;
            AliveState = AliveState.Alive;
        }
        public int Id { get; protected set; }
        public string Name { get; protected set; }
        public int Health { get; protected set; }
        public int Power { get; protected set; }
        public AliveState AliveState { get; protected set; }

      
        public void SetId()
        {
            if (characters.Count > 0)
                Id = characters.Last().Id + 1;

            else Id = 1;
        }
        public static void AddToList(Character character)
        {
            characters.Add(character);
        }
        public abstract void UnderAttacked(int power);
        public abstract void ShowCharacter();
    }

    public enum AliveState
    {
        Alive,
        Dead
    }
}
