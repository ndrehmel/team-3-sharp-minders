using NUnit.Framework;
using levelup;

namespace levelup
{
    [TestFixture]
    public class GameControllerTest
    {
        private GameController? testObj;

        [SetUp]
        public void SetUp()
        {
            testObj = new GameController();
        }

        [Test]
        public void IsGameResultInitialized()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            Assert.IsNotNull(testObj.GetStatus());
        }

        [Test]
        public void IsCharacterNameDefaultTaken()
        {
#pragma warning disable CS8602 // Rethrow to preserve stack details
            testObj.CreateCharacter("");
            Assert.AreEqual(testObj.TestCharacterName, testObj.status.characterName);
            Assert.AreEqual(testObj.charObj.Name, testObj.status.characterName);
            //Assert.IsNotNull(testObj.status.characterName);
        }
    }
}