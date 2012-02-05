using NUnit.Framework;
using TechTalk.SpecFlow;

namespace bare.bones.app.acceptance.tests.StepDefinitions
{
    [Binding]
    public class BareBonesStepDefinitions : BareBonesBaseStepDefinitions
    {
        [Then(@"the main window shows ""(.*)"" as its message")]
        public void ThenTheMainWindowShowsHelloWorldAsItsMessage(string message)
        {
            Assert.AreEqual("Hello World!", BareBonesApplicationRunner.MainWindowMessage);
        }
    }
}