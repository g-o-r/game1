using System;
using White.Core;
using White.Core.Factory;
using White.Core.UIItems;
using White.Core.UIItems.Finders;

namespace bare.bones.app.acceptance.tests.StepDefinitions
{
    internal class BareBonesMainWindow
    {
        private readonly Application _bareBonesApplication;

        public BareBonesMainWindow(Application bareBonesApplication)
        {
            if (bareBonesApplication == null) throw new ArgumentNullException("bareBonesApplication");
            _bareBonesApplication = bareBonesApplication;
        }

        public string Message
        {
            get
            {
                return
                    _bareBonesApplication.GetWindow(SearchCriteria.ByText("Bare Bones"),
                                                    InitializeOption.WithCache).Get<Label>(
                                                        SearchCriteria.ByAutomationId("MessageLabel")).Text;
            }
        }
    }
}