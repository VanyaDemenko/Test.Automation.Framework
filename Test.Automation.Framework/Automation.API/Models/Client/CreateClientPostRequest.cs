using Newtonsoft.Json;

namespace Automation.API.Models.Client
{
    public class CreateClientPostRequest : ClientProperties
    {
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
