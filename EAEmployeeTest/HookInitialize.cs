using EAAutoFramework.Base;
using TechTalk.SpecFlow;
using EAAutoFramework.Helpers;

namespace EAEmployeeTest
{

    [Binding]
    public class HookInitialize : TestInitializeHook
    {

        public HookInitialize() : base(BrowserType.FireFox)
        {
            InitializeSettings();
            NavigateSite();
        }


        [BeforeFeature]
        public static void TestStart()
        {
            HookInitialize init = new HookInitialize();
        }

    }
}
