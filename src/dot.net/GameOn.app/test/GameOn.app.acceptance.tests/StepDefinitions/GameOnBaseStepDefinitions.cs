using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace GameOn.app.acceptance.tests.StepDefinitions
{
    [Binding]
    public class GameOnBaseStepDefinitions
    {
        protected static GameOnApplicationRunner GameOnApplicationRunner;

        [BeforeScenario]
        public static void RunGameOn()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "GameOn.main.exe");
            GameOnApplicationRunner = new GameOnApplicationRunner(path);
        }

        [AfterScenario]
        public static void EndGameOn()
        {
            GameOnApplicationRunner.Kill();
        }
    }
}