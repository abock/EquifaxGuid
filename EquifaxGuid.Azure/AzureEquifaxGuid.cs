using System.Linq;
using System.Net;
using System.Net.Http;

using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace Equifax.Azure
{
    public static class EquifaxGuid
    {
        [FunctionName("EquifaxGuid")]
        public static HttpResponseMessage Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get")] HttpRequestMessage req,
            TraceWriter log)
            => req.CreateResponse(
                HttpStatusCode.OK,
                string.Join("\n", Enumerable.Range(0, 10).Select(i => Guid.NewGuid().ToString())),
                "text/plain");
    }
}
