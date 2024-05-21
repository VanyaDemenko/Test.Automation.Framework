using Automation.Common.Interfaces;
using Newtonsoft.Json;

namespace Automation.API.Models.Client
{
    public class ClientProperties : IEntity
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
