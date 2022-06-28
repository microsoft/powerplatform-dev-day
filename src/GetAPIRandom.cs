using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace PPDD
{
    public class GetAPIRandom
    {
        private readonly HttpClient _client;

        public GetAPIRandom(IHttpClientFactory httpClientFactory)
        {
            this._client = httpClientFactory.CreateClient();
        }

        [FunctionName("GetAPIRandom")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log
        )
        {
            var result = await SendRequest(req, log, "random");
            return new OkObjectResult(result);
        }

        public async Task<string> SendRequest(HttpRequest req, ILogger log, string endpointType)
        {
            var url = $"https://api.publicapis.org/{endpointType}?";

            string title = req.Query["title"];
            string description = req.Query["description"];
            string auth = req.Query["auth"];
            string https = req.Query["https"];
            string cors = req.Query["cors"];
            string category = req.Query["category"];

            url = title is null ? url : url + "title=" + title.Trim().ToLower() + "&";
            url = description is null
                ? url
                : url + "description=" + description.Trim().ToLower() + "&";
            url = auth is null ? url : url + "auth=" + auth.Trim().ToLower() + "&";
            url = https is null ? url : url + "https=" + https.Trim().ToLower() + "&";
            url = cors is null ? url : url + "cors=" + cors.Trim().ToLower() + "&";
            url = category is null ? url : url + "category=" + category.Trim().ToLower() + "&";
            url = url.Substring(0, url.Length - 1);

            log.Log(LogLevel.Information, url);

            var response = await _client.GetAsync(url);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
