using NUnit.Framework;
using levelup;
using System.Drawing;
//using levelup.GameController;

namespace levelup
{
    [TestFixture]
    public class GameMapTest
    {
        private GameMap? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameMap();
        }

        [Test]
        public void ValidateStepNorth()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Point test = new Point(5,5);
            test = testObj.calculatePosition(test, GameController.DIRECTION.NORTH);
            Assert.AreEqual(test.X, 5);
            Assert.AreEqual(test.Y, 6);
        }

         [Test]
        public void ValidateStepSouth()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Point test = new Point(5,5);
            test = testObj.calculatePosition(test, GameController.DIRECTION.SOUTH);
            Assert.AreEqual(test.X, 5);
            Assert.AreEqual(test.Y, 4);
        }

         [Test]
        public void ValidateStepEast()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Point test = new Point(5,5);
            test = testObj.calculatePosition(test, GameController.DIRECTION.EAST);
            Assert.AreEqual(test.X, 6);
            Assert.AreEqual(test.Y, 5);
        }

     [Test]
        public void ValidateStepWest()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Point test = new Point(5,5);
            test = testObj.calculatePosition(test, GameController.DIRECTION.WEST);
            Assert.AreEqual(test.X, 4);
            Assert.AreEqual(test.Y, 5);
        }
    }
}