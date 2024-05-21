using TechTalk.SpecFlow;

namespace Automation.Tests.Steps.Base
{
    [Binding]
    public class BaseSteps
    {
        private readonly FeatureContext _featureContext;
        private readonly ScenarioContext _scenarioContext;

        protected BaseSteps(FeatureContext featureContext, ScenarioContext scenarioContext)
        {
            _featureContext = featureContext ?? throw new ArgumentNullException(nameof(featureContext));
            _scenarioContext = scenarioContext ?? throw new ArgumentNullException(nameof(scenarioContext));
        }

        protected FeatureContext FeatureContext => _featureContext;

        protected ScenarioContext ScenarioContext => _scenarioContext;
    }
}
