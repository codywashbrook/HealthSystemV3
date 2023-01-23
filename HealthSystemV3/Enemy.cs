using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV3
{
    internal class Enemy : GameCharacter
    {
        public Enemy(string name) : base(name)
        {
        }

        public new void ShowStats() //overrides gamecharacter using base
        {
            base.ShowStats();
        }
    }
}
