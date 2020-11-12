using Microsoft.VisualStudio.TestTools.UnitTesting;
using BowlingGame;

namespace BowlingGameTests
{
    [TestClass]
    public class GameTests
    {
        private Game game;
        private Calculator calculator;

        [TestInitialize]
        public void Initialize()
        {
            this.calculator = new Calculator();
            this.game = new Game(calculator);
        }

        [TestMethod]
        public void TestGutterGame()
        {
            for (var i = 0; i < 20; i++)
                game.Roll(0);

            Assert.AreEqual(0, game.Score());
        }

        [TestMethod]
        public void TestAllOnes()
        {
            for (var i = 0; i < 20; i++)
                game.Roll(1);

            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        public void TestOneSpare()
        {
            game.Roll(5);
            game.Roll(5);
            game.Roll(3);

            for (var i = 0; i < 17; i++)
                game.Roll(0);

            Assert.AreEqual(16, game.Score());
        }

        [TestMethod]
        public void TestStrikeFrame10()
        {
            for (var i = 0; i < 18; i++)
                game.Roll(0);
            game.Roll(10);
            game.Roll(10);
            game.Roll(10);

            Assert.AreEqual(30, game.Score());
        }

        [TestMethod]
        public void TestSpareFrame10()
        {
            for (var i = 0; i < 18; i++)
                game.Roll(0);
            game.Roll(9);
            game.Roll(1);
            game.Roll(10);

            Assert.AreEqual(20, game.Score());
        }

        [TestMethod]
        public void TestStrikeThenSpare()
        {
            game.Roll(10);
            game.Roll(9);
            game.Roll(1);

            Assert.AreEqual(30, game.Score());
        }

        [TestMethod]
        public void TestSpareThenStrike()
        {
            game.Roll(9);
            game.Roll(1);
            game.Roll(10);

            Assert.AreEqual(30, game.Score());
        }

        [TestMethod]
        public void TestStrikeThenMiss()
        {
            game.Roll(10);
            game.Roll(0);
            game.Roll(10);
            game.Roll(7);
            game.Roll(1);

            Assert.AreEqual(45, game.Score());
        }
    }
}
