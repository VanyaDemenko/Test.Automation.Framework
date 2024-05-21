using Newtonsoft.Json;

namespace Automation.API.Models.Client
{
    public class CreateClientPostResponse : ClientProperties
    {
        [JsonProperty("age")]
        public long Age { get; set; }

        [JsonProperty("adi")]
        public string? Adi { get; set; }
    }
}
