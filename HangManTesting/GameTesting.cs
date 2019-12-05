using NUnit.Framework;
using HangMan;
namespace HangManTesting
{
    public class GameTesting
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]

        public void IsGuessedLetters_GivenAChar_ReturnTrue()
        {
            char testGuess = 'a';

            Game game = new Game();
            game.GuessedLetters();
            game.guess = 'a';
            Assert.True(game.guess == testGuess);
        }
    }
}