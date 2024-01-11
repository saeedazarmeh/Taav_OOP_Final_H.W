using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    public class Utility
    {
        public static void ShowCharaters()
        {
            foreach(var character in Character.characters)
            {
                character.ShowCharacter();
            }
        }
    }
}
