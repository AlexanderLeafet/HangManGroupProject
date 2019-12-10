using NUnit.Framework;
using HangMan;
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
        public void Lives_WrongDataType_ReturnsNotEqual()
        {
            string stringLife = "5";

            Game game = new Game();
            int actualLives = game.lives;

            Assert.AreNotEqual(stringLife, actualLives);

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
        public void DeacreaseLives_LivesIs5_ReturnLivesIs4()
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
        //[Test]
        //public void WordHandling_WordIsABC_HiddenIs___()
        //{

        //    Game game = new Game();
        //    game.wordBank = new string[] { "ABC" };

        //    game.WordHandling();

        //    Assert.True(result);
        //}

        [Test]
        public void GameWon_givenTDD_returnFalse()
        {

            Game game = new Game();
            game.wordToGuess = "TDD";
            game.lettersRevealed = 2;
            var result = game.GameWon();

            Assert.False(result);
        }
        
    }
}