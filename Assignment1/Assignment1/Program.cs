using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game("Minecraft", 16);
            var gameWithTimeLimit = new GameWithTimeLimit("Team Fortress 2", 32, 1000);

            Console.WriteLine(game);
            Console.WriteLine(gameWithTimeLimit);

            Console.ReadLine();
        }
    }
}
