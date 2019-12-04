using System;
using System.Collections.Generic;
using System.Text;

namespace HangMan
{
    public class Game
    {
        string[] words = System.IO.File.ReadAllLines(@"C:\Users\Philip\GitHub\Projekt\TestingCourse\HangMan\Words.txt");

        public void printWords()
        {
            foreach (var word in words)
            {
                Console.WriteLine(word);
            }
        }

	

	

    }
}
