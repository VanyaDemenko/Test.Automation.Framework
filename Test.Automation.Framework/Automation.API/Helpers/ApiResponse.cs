using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace Automation.API.Helpers
{
    public class ApiResponse
    {
        public HttpStatusCode StatusCode { get; }
        public string? Content { get; private set; }
        public IReadOnlyCollection<HeaderParameter>? Headers { get; private set; }

        public ApiResponse(RestResponseBase responseMessage)
        {
            StatusCode = responseMessage.StatusCode;
            Content = responseMessage.Content;
            Headers = responseMessage.Headers;
        }

        public T GetContent<T>()
        {
            try
            {
                return JsonConvert.DeserializeObject<T>(Content);
            }
            catch (Exception)
            {
                throw new Exception(
                    $"Error deserializing content. StatusCode = {StatusCode} \nContent = {Content}");
            }
        }

        public bool IfSuccessful()
        {
            return (int)StatusCode >= 200 && (int)StatusCode < 300;
        }
    }
}
