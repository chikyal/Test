using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using QuizApi.Utils;

namespace QuizApi.Controllers
{
    [RoutePrefix("demo")]
    public class DemoController : BaseController
    {
        [Route("time")]
        public HttpResponseMessage GetCurrentAccount(int version)
        {
            ValidateApiVersionAndState(version);
            
            return Request.CreateResponse(HttpStatusCode.OK, new { ServerTime = DateTime.UtcNow });
        }

      
    }
}
