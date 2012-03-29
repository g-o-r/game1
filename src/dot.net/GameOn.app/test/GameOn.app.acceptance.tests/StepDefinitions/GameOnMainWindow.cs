using System;
using White.Core;
using White.Core.Factory;
using White.Core.UIItems;
using White.Core.UIItems.Finders;

namespace GameOn.app.acceptance.tests.StepDefinitions
{
    internal class GameOnMainWindow
    {
        private readonly Application _bareBonesApplication;

        public GameOnMainWindow(Application bareBonesApplication)
        {
            if (bareBonesApplication == null) throw new ArgumentNullException("bareBonesApplication");
            _bareBonesApplication = bareBonesApplication;
        }

        public string Message
        {
            get
            {
                return
                    _bareBonesApplication.GetWindow(SearchCriteria.ByText("Game On"),
                                                    InitializeOption.WithCache).Get<Label>(
                                                        SearchCriteria.ByAutomationId("MessageLabel")).Text;
            }
        }
    }
}