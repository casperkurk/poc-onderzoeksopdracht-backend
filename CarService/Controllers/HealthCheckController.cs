using System.Web.Http;

namespace CarService.Controllers
{
    public class HealthCheckController: ApiController
    {
        [HttpGet]
        [Route("api/checkhealth")]
        public IHttpActionResult CheckHealth()
        {
            return Ok();
        }
    }
}