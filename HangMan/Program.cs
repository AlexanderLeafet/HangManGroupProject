using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


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
                game.GameStatus();
                Console.WriteLine();
                
                
            } while (game.gameWon == false && game.gameLost == false);
            Console.ReadKey();
            
           
        }
    }
}
