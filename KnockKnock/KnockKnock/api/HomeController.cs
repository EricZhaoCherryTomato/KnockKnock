using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace KnockKnock.api
{
    public class HomeController : ApiController
    {
        [Route("")]
        public HttpResponseMessage Get()
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent("Hello, world!");
            return response;
        }
    }
}