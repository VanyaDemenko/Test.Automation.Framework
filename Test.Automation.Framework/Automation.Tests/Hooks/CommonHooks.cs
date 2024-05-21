using Automation.Common.Utils.EnvironmentManager;
using Automation.Tests.Steps.Base;
using TechTalk.SpecFlow;
using Logger = Automation.Common.Utils.Logging.Logger;

namespace Automation.Tests.Hooks
{
    [Binding]
    public class CommonHooks : BaseSteps
    {
        public CommonHooks(FeatureContext featureContext, ScenarioContext scenarioContext)
            : base(featureContext, scenarioContext) { }

        [BeforeTestRun(Order = -30000)]
        public static void SetUpAppSettings()
        {
            Logger.SetUp();
            var currentEnvironmentName = Environment.GetEnvironmentVariable("env") ?? EnvironmentManager.GetLocal();
            EnvironmentManager.LoadSettings(currentEnvironmentName);
        }
    }
}
