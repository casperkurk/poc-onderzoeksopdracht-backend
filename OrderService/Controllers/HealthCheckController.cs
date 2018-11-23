using System.Web.Http;

namespace OrderService.Controllers
{
    public class HealthCheckController: ApiController
    {
        [HttpGet]
        [Route("api/checkhealth")]
        public IHttpActionResult CheckHealth()
        {
            return Ok("orderservice");
        }
    }
}