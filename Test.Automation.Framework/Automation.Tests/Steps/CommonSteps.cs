using Automation.API.Helpers;
using Automation.Tests.Steps.Base;
using FluentAssertions;
using System.Net;
using TechTalk.SpecFlow;

namespace Automation.Tests.Steps
{
    [Binding]
    public class CommonSteps : BaseSteps
    {
        public CommonSteps(FeatureContext featureContext, ScenarioContext scenarioContext) 
            : base(featureContext, scenarioContext){}

        [Then(@"The last response status code '(should|should not)' be equal to '(\d+)'")]
        public void ThenTheLastResponseStatusCodeShouldBeEqualTo(bool expectedState, int expectedStatusCode)
        {
            var actualStatusCode = ScenarioContext.Get<ApiResponse>().StatusCode;

            if (expectedState) actualStatusCode.Should().Be((HttpStatusCode)expectedStatusCode);
            else actualStatusCode.Should().NotBe((HttpStatusCode)expectedStatusCode);
        }
    }
}
