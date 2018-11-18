using System.Web.Http;

namespace MotorcycleService.Controllers
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