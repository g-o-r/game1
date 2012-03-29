using NUnit.Framework;
using TechTalk.SpecFlow;

namespace GameOn.app.acceptance.tests.StepDefinitions
{
    [Binding]
    public class GameOnStepDefinitions : GameOnBaseStepDefinitions
    {
        [Then(@"the main window shows ""(.*)"" as its message")]
        public void ThenTheMainWindowShowsHelloWorldAsItsMessage(string message)
        {
            Assert.AreEqual("Hello World!", GameOnApplicationRunner.MainWindowMessage);
        }
    }
}