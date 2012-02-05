using NUnit.Framework;

namespace bare.bones.proj
{
    [TestFixture]
    [Category("commit.stage")]
    public class BareBonesTests
    {
        [Test]
        public void DisplaysHelloWorld()
        {
            Assert.AreEqual("Hello World!", new BareBones().HelloWorld());
        }
    }
}
