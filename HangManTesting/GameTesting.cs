using NUnit.Framework;
using HangMan;
using System.IO;
using System;

namespace HangManTesting
{
    public class GameTesting
    {
        [Test]
        public void CreateGame_StartingLives_IsFive()
        {
            int expectedLives = 5;

            Game game = new Game();
            int actualLives = game.lives;

            Assert.AreEqual(actualLives, expectedLives);
        }

        [Test]
        public void CreateGame_WrongDataType_ReturnsNotEqual()
        {
            string stringLife = "5";

            Game game = new Game();
            int actualLives = game.lives;

            Assert.AreNotEqual(stringLife, actualLives);
        }

        [Test]
        public void CreateGame_NegativeStartingLives_ReturnNotEqual()
        {
            Game game = new Game();
            int testLives = -1;

            Assert.AreNotEqual(testLives, game.lives);
        }

        [Test]
        public void DecreaseLives_Given5_Return4()
        {
            Game game = new Game();
            game.lives = 5;
            int sum = game.DecreasingLives();

            Assert.AreEqual(sum, 4);
        }

        [Test]
        public void DecreaseLives_LivesIs5_ReturnLivesIs4()
        {
            Game game = new Game();
            game.DecreasingLives();

            Assert.AreEqual(game.lives, 4);
        }

        [Test]
        public void LetterInput_GivenHey_ReturnH()
        {
            string input = "Hey";

            Game game = new Game();
            var testInput = game.InputStringToChar(input);

            Assert.AreEqual(testInput, 'H');
        }

        [Test]
        public void LetterInput_GivenLowercase_ReturnUppercase()
        {
            string input = "h";

            Game game = new Game();
            var testInput = game.InputStringToChar(input);

            Assert.AreEqual(testInput, 'H');
        }

        [Test]
        public void GameLost_givenZeroLives_returnTrue()
        {

            Game game = new Game();

            game.lives = 0;

            bool result = game.GameLost();

            Assert.True(result);

        }
        [Test]
        public void GameLost_givenFourLives_returnFalse()
        {

            Game game = new Game();
            game.lives = 4;
            bool result = game.GameLost();

            Assert.False(result);

        }

        [Test]
        public void GameWon_givenTDD_returnTrue()
        {
            Game game = new Game();
            game.wordToGuess = "TDD";
            game.lettersRevealed = 3;
            var result = game.GameWon();

            Assert.True(result);
        }

        [Test]
        public void GameWon_givenTDD_returnFalse()
        {
            Game game = new Game();
            game.wordToGuess = "TDD";
            game.lettersRevealed = 2;
            var result = game.GameWon();

            Assert.False(result);
        }

        [Test]
        public void WordHandling_UnderscoreReplaceChars_returnTrue()
        {
            Game game = new Game();
            game.random = new MyRandom();

            game.WordHandling();
            var amountOfUnderscores = game.displayToPlayer.Length;

            Assert.AreEqual(amountOfUnderscores, 7); // Set word = Arrange, 7 chars
        }

        [Test]
        public void MyRandom_RandomizeBetweenZeroAndTen_ReturnSeven()
        {
            Game game = new Game();
            game.random = new MyRandom();

            var sum = game.random.Next(0, 10);

            Assert.AreEqual(sum, 7);
        }
        [Test]
        public void MyRandom_RandomizeBetweenZeroAndFour_ReturnSeven()
        {
            Game game = new Game();
            game.random = new MyRandom();

            var sum = game.random.Next(0, 4);

            Assert.AreEqual(sum, 7);
        }

        [Test]
        public void MyRandom_RandomizeBetweenZeroAndTen_ReturnFalseGivenSix()
        {
            Game game = new Game();
            game.random = new MyRandom();

            var sum = game.random.Next(0, 10);

            Assert.AreNotEqual(sum, 6);
        }

        [Test]
        public void MyRandom_RandomizeBetweenEightAndTwelve_ReturnSeven()
        {
            Game game = new Game();
            game.random = new MyRandom();

            var sum = game.random.Next(8, 12);

            Assert.AreEqual(sum, 7);
        }
        [Test]
        public void MyRandom_RandomizeBetweenNegativeNumbers_Return7()
        {
            Game game = new Game();
            game.random = new MyRandom();

            var sum = game.random.Next(-4, -1);

            Assert.AreEqual(sum, 7);
        }
        [Test]
        public void MyRandom_RandomizeBetweenNegativeNumbers()
        {
            Game game = new Game();
            game.random = new MyRandom();

            game.wordToGuess = "TDD";
            game.WordHandling();

            Assert.AreEqual(game.wordToGuess, "ARRANGE");
        }
        
        //[Test]
        //public void CreatePlayer_GivenNumber_ReturnFalse()
        //{
        //    Game game = new Game();
            

        //    using (StringWriter sw = new StringWriter())
        //    {
        //        Console.SetOut(sw);

        //        StringReader sr = new StringReader(string.Format($"{game.playerName}", Environment.NewLine));
        //        {
        //            Console.SetIn(sr);

        //            string expected = string.Format("C3PO", Environment.NewLine);

        //            Assert.AreEqual(expected, sw);
        //        }
                    
        //    }
            
        //}

    }
}