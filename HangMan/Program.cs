using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HangMan
{
    public class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.WordHandling();
            do
            {
                game.LetterInput();
                game.DoesLetterExistInTheWord();
                game.GameStatus();
                Console.WriteLine();
               // Console.ReadKey();
            } while (game.gameWon == false && game.gameLost == false);
            Console.ReadKey();
            
            
           
        }
    }
}
