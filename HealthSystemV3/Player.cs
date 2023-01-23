using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV3
{
    internal class Player : GameCharacter // // inherits game character
    {
        public int lives = 3; //fields that enemy wouldn't have so stored here instead of game character

        public Player(string name) : base(name)
        {

        }
        public new void ShowStats() //overrides gamecharacter using base
        {
            base.ShowStats();
            Console.WriteLine("lives: " + lives);
        }


    }
}
