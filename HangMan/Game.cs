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
            int i = 0;
            Console.WriteLine(words[0]);
        }

	

	

    }
}
