using NUnit.Framework;
using HangMan;
namespace HangManTesting
{
    public class GameTesting
    {
        [Test]
        public void Lives_EqualsFive_ReturnTrue()
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
            int lives = 5;

            Game game = new Game();
            int sum = game.DecreasingLives(lives);
            
            Assert.AreEqual(sum, 4);
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
        public void GameLost_givenZero_returnTrue()
        {

            Game game = new Game();
            int lifeZero = 0;

            bool result = game.GameLost(lifeZero);

            Assert.True(result);

        }
        [Test]
        public void GameLost_givenFour_returnFalse()
        {
            int life = 4;
            Game game = new Game();
            bool result = game.GameLost(life);

            Assert.False(result);

        }
        //[Test]
        //public void GameLost_GivenOne_ReturnGameLostFalse()
        //{
        //    int lifeZero = 1;
        //    Game game = new Game();
        //    bool result = game.GameLost(lifeZero);

        //    Assert.False(result);

        //}
    }
}