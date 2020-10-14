using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new game, start it and call game loop
            // Ask if user would like to play another round

            Game game = new Game();
            //new game
            while (true)
            {
                game.StartNewGame();
                game.Loop();
                Console.Write("Another round?");
                string answer = Console.ReadLine().ToLower();
                if (answer != "y" && answer != "yes")
                {
                    break;
                }

            }
        }
    }
}
