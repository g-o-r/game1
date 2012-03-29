using System;
using System.IO;
using System.Reflection;
using White.Core;

namespace GameOn.app.acceptance.tests.StepDefinitions
{
    public class GameOnApplicationRunner
    {
        private readonly Application GameOnApplication;
        private readonly GameOnMainWindow MainWindow;

        public GameOnApplicationRunner(string bareBonesAreBonesExeLocation)
        {
            string fullPathToExe = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                                bareBonesAreBonesExeLocation);
            try
            {
                GameOnApplication = Application.Launch(fullPathToExe);
            }
            catch (Exception exception)
            {
                throw new Exception(string.Format("Error launching app '{0}'.", fullPathToExe), exception);
            }
            MainWindow = new GameOnMainWindow(GameOnApplication);
        }

        public string MainWindowMessage
        {
            get { return MainWindow.Message; }
        }

        public void Kill()
        {
            GameOnApplication.Kill();
        }
    }
}