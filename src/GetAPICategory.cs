using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Net.Http;

namespace ppdd
{
    public class GetAPICategory
    {
        
        private readonly HttpClient _client;

        public GetAPICategory(IHttpClientFactory httpClientFactory)
        {
            this._client = httpClientFactory.CreateClient();
        }

        [FunctionName("GetAPICategory")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log
        )
        {
            var url = "https://api.publicapis.org/categories";
            var response = await _client.GetAsync(url);
            var result = await response.Content.ReadAsStringAsync();
            return new OkObjectResult(result);
        }
    }
}
