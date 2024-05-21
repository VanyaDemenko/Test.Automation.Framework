using Automation.API.Builders;
using Automation.API.Clients;
using Automation.API.Helpers;
using Automation.API.Models.Client;
using Newtonsoft.Json;
using RestSharp;
using static Automation.Common.Utils.EnvironmentManager.EnvironmentManager;

namespace Automation.API.Services
{
    public class ClientService
    {
        private readonly RexpApiClient _client;

        private const string Client = "/client";

        public ClientService()
        {
            _client = new RexpApiClient(CurrentEnvironment.BaseApiUrl);
        }

        public ApiResponse CreateClient(CreateClientPostRequest createClientPostRequest)
        {
            var requestBody = JsonConvert.SerializeObject(createClientPostRequest);
            var request = new RequestBuilder().WithMethod(Method.Post).WithHeader("Content-Type", "application/json").WithResource(Client)
                .WithBody(requestBody).CreateRequest();
            return _client.Execute(request);
        }
    }
}
