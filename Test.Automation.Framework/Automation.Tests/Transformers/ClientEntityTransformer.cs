using Automation.API.Models.Client;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Automation.Tests.Transformers
{
    [Binding]
    public static class ClientEntityTransformer
    {
        [StepArgumentTransformation]
        public static CreateClientPostRequest ToCreateClientPostRequest(Table table)
        {
            return table.CreateInstance<CreateClientPostRequest>();
        }

        [StepArgumentTransformation]
        public static CreateClientPostResponse ToCreateClientPostResponse(Table table)
        {
            return table.CreateInstance<CreateClientPostResponse>();
        }
    }
}
