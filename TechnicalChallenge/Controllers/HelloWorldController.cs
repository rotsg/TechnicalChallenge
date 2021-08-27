using System.Web.Http;

namespace TechnicalChallenge.Controllers
{
    public class HelloWorldController : ApiController
    {
        public string Get()
        {
            return "Hello World";
        }
    }
}