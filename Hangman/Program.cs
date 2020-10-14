using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            Hangman game = new Hangman();
             game.NewGame();

            while (!game.IsWordGuessed())
            {
                Console.Write("Enter letter: ");                    
                if (game.Guess(Console.ReadLine()[0]))
                {
                    Console.WriteLine(game.GetWord());
                }
                else
                {
                    Console.WriteLine("This letter is not in the word");
                }
            }
            Console.WriteLine("You have successfully guessed the word");
            Console.Read();
        }
    }
}
