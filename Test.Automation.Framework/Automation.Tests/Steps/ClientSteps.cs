using Automation.API.Helpers;
using Automation.API.Models.Client;
using Automation.API.Services;
using Automation.Tests.Extensions;
using Automation.Tests.Steps.Base;
using TechTalk.SpecFlow;

namespace Automation.Tests.Steps
{
    [Binding]
    public class ClientSteps : BaseSteps
    {
        private readonly ClientService _clientService;

        public ClientSteps(FeatureContext featureContext, ScenarioContext scenarioContext,
            ClientService clientService) : base(featureContext, scenarioContext)
        {
            _clientService = clientService;
        }

        [When(@"I create a new client via API")]
        public void WhenICreateANewClientViaAPI(CreateClientPostRequest client)
        {
            var response = _clientService.CreateClient(client);
            ScenarioContext.Set(response);
        }

        /* Actions Validation */

        [Then(@"The Client response '(has|doesn't have)' the following data")]
        public void ThenTheClientResponseHasTheFollowingData(bool expectedState, CreateClientPostResponse expectedClientResponse)
        {
            var actualClientResponse = ScenarioContext.Get<ApiResponse>().GetContent<CreateClientPostResponse>();

            if (expectedState) actualClientResponse.AllPropertiesShouldHaveEquivalent(expectedClientResponse);
            else actualClientResponse.AllPropertiesShouldNotHaveEquivalent(expectedClientResponse);
        }
    }
}
