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
    [Test]
        public void Validate55()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Point test = new Point(5,5);
            bool validation = testObj.validatePosition(test);
            Assert.AreEqual(validation, true);
        }

        [Test]
        public void ValidateStep109()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Point test = new Point(10,9);
            bool validation = testObj.validatePosition(test);
            Assert.AreEqual(validation, false);
        }
      [Test]
        public void ValidateStep810()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Point test = new Point(8,10);
            bool validation = testObj.validatePosition(test);
            Assert.AreEqual(validation, false);
        }
    [Test]
        public void ValidateStepneg17()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Point test = new Point(-1,7);
            bool validation = testObj.validatePosition(test);
            Assert.AreEqual(validation, false);
        }
        [Test]
        public void ValidateStep8neg1()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Point test = new Point(8,-1);
            bool validation = testObj.validatePosition(test);
            Assert.AreEqual(validation, false);
        }
    }
}