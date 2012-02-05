using System;
using System.IO;
using System.Reflection;
using White.Core;

namespace bare.bones.app.acceptance.tests.StepDefinitions
{
    public class BareBonesApplicationRunner
    {
        private readonly Application BareBonesApplication;
        private readonly BareBonesMainWindow MainWindow;

        public BareBonesApplicationRunner(string bareBonesAreBonesExeLocation)
        {
            string fullPathToExe = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                                                bareBonesAreBonesExeLocation);
            try
            {
                BareBonesApplication = Application.Launch(fullPathToExe);
            }
            catch (Exception exception)
            {
                throw new Exception(string.Format("Error launching app '{0}'.", fullPathToExe), exception);
            }
            MainWindow = new BareBonesMainWindow(BareBonesApplication);
        }

        public string MainWindowMessage
        {
            get { return MainWindow.Message; }
        }

        public void Kill()
        {
            BareBonesApplication.Kill();
        }
    }
}