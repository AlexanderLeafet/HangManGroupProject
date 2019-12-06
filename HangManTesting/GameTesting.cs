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


    }
}