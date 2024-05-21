using Automation.API.Helpers;

namespace Automation.API.Exceptions
{
    public class HttpException : Exception
    {
        private const string ErrorMessage = "StatusCode = {0} \nContent = {1}";

        public HttpException(ApiResponse response) : base(string.Format(ErrorMessage, response.StatusCode, response.Content))
        {
        }
    }
}
