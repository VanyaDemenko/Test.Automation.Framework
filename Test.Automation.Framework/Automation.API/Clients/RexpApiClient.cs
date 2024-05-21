using Automation.API.Helpers;
using RestSharp;

namespace Automation.API.Clients
{
    public class RexpApiClient
    {
        private readonly RestClient _restClient;

        public RexpApiClient(string url)
        {
            _restClient = new RestClient(url);
        }

        public ApiResponse Execute(RestRequest restRequest)
        {
            var response = _restClient.Execute(restRequest);
            return new ApiResponse(response);
        }
    }
}
