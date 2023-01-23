using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthSystemV3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance"); //combines multiple methods and fields into one if needed
            Console.WriteLine();

            // instantiate classes
            //GameCharacter gameCharacter = new GameCharacter();
            Player player = new Player("cody");
            Enemy enemy = new Enemy("enemy");
            Console.WriteLine();

            //gameCharacter.ShowStats();
            //gameCharacter.TakeDamage(5);
            //gameCharacter.ShowStats();

            player.ShowStats();
            player.TakeDamage(5);
            player.ShowStats();
            player.Heal(15);
            player.ShowStats();

            Console.WriteLine();

            enemy.ShowStats();
            enemy.TakeDamage(5);
            enemy.ShowStats();
            enemy.Heal(15);
            enemy.ShowStats();

            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
