using System.IO;
using System.Reflection;
using TechTalk.SpecFlow;

namespace bare.bones.app.acceptance.tests.StepDefinitions
{
    [Binding]
    public class BareBonesBaseStepDefinitions
    {
        protected static BareBonesApplicationRunner BareBonesApplicationRunner;

        [BeforeScenario]
        public static void RunBareBones()
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "bare.bones.main.exe");
            BareBonesApplicationRunner = new BareBonesApplicationRunner(path);
        }

        [AfterScenario]
        public static void EndBareBones()
        {
            BareBonesApplicationRunner.Kill();
        }
    }
}