using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HangMan
{
    public class Game
    {
        Random random = new Random();

        public char guess;
        public string wordToGuess;
        public string wordToGuessUppercase;
        public int lives = 5;
        public int lettersRevealed = 0;
        public bool gameWon = false;
        public bool gameLost = false;

        StringBuilder displayToPlayer;

        string[] wordBank = File.ReadAllLines("Words.txt");
        List<char> GuessedLetter = new List<char>();

        public void WordHandling()
        {
            wordToGuess = wordBank[random.Next(0, wordBank.Length)];
            wordToGuessUppercase = wordToGuess.ToUpper();
            displayToPlayer = new StringBuilder(wordToGuess.Length);
            //Console.WriteLine(wordToGuessUppercase); //makes the hidden word Uppercase
            for (int i = 0; i < wordToGuess.Length; i++)
                displayToPlayer.Append('_');
        }

        public char LetterInput()
        {
            Console.WriteLine(displayToPlayer); //prints out all the underscores and matches the length of the word
            Console.Write("Enter your guess letter: ");
            string input = Console.ReadLine(); //Stores user input and makes it Uppercase
            InputStringToChar(input);
           
            GuessedLetter.Add(guess); // Adds that letter to a list of chars

            return guess;
        }

        public char InputStringToChar(string input)
        {
            var answer = input[0];//stores the first letter in userinput to "guess" for example: HEY would be H
                             //This is so that you can't guess several letters at once
            guess = char.ToUpper(answer);

            return guess;
        }

        public bool DoesLetterExistInTheWord()
        {
            if (wordToGuess.Contains(guess))
            {
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuessUppercase[i] == guess)
                    {
                        displayToPlayer[i] = wordToGuess[i];
                        lettersRevealed++;
                    }
                }
                Console.WriteLine("The word contains your guessed letter.");
                return true;
            }
            else 
            {
                Console.WriteLine("The word does not contains your guessed letter.");
                DecreasingLives(lives);
                return false;
            }        
        }

        public void GameStatus()
        {

            GameLost(lives);
            GameWon();
           
           

        }

        public int DecreasingLives(int lifeInput)
        {
            lives = lifeInput;
            lives--;

            return lives;
        }
        public bool GameLost(int livesInput)
      {
            lives = livesInput;

            Console.WriteLine($"Remaining lives: {lives}");
            if (lives == 0)
            {
                Console.WriteLine("YOU DEAD!");
                //Console.ReadKey();

                return gameLost = true;
            }
            //else if (lives == 1)
            //{
            //    return gameLost = true;
            //}
            else
            {
                return gameLost = false;
            }

        }
        public bool GameWon()
        {
            if (lettersRevealed == wordToGuess.Length)
            {
                Console.WriteLine("\nYOU WIN!!!");
                Console.WriteLine($"The word was {wordToGuess}");
                Console.ReadKey();
                return gameWon = true;
            }

            else
            {
                return gameWon = false;
            }
        }

            
}














            /*StringBuilder displayToPlayer = new StringBuilder(wordToGuess.Length);
            for (int i = 0; i < wordToGuess.Length; i++)
                displayToPlayer.Append('_');

            List<char> correctGuesses = new List<char>();
            List<char> incorrectGuesses = new List<char>();

            int lives = 5;
            bool won = false;
            int lettersRevealed = 0;

            string input;
            char guess;

            while (!won && lives > 0)
            {
                Console.Write("Guess a letter: ");

                input = Console.ReadLine().ToUpper();
                guess = input[0];

                if (correctGuesses.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was correct!", guess);
                    continue;
                }
                else if (incorrectGuesses.Contains(guess))
                {
                    Console.WriteLine("You've already tried '{0}', and it was wrong!", guess);
                    continue;
                }

                if (wordToGuessUppercase.Contains(guess))
                {
                    correctGuesses.Add(guess);

                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuessUppercase[i] == guess)
                        {
                            displayToPlayer[i] = wordToGuess[i];
                            lettersRevealed++;
                        }
                    }
                    if (lettersRevealed == wordToGuess.Length)
                        won = true;
                }
                else
                {
                    incorrectGuesses.Add(guess);

                    Console.WriteLine("Nope, there's no '{0}' in it!", guess);
                    lives--;
                }

                Console.WriteLine(displayToPlayer.ToString());
            }

            if (won)
                Console.WriteLine("You won!");
            else
                Console.WriteLine("You lost! It was '{0}'", wordToGuess);

            Console.Write("Press ENTER to exit...");
            Console.ReadLine();
            */
        

 }

