using NUnit.Framework;

namespace GameOn.proj
{
    [TestFixture]
    [Category("commit.stage")]
    public class GameOnTests
    {
        [Test]
        public void DisplaysHelloWorld()
        {
            Assert.AreEqual("Hello World!", new GameOn().HelloWorld());
        }
    }
}
