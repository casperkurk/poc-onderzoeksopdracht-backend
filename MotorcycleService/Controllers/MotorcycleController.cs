using System.Web.Http;
using MotorcycleService.Util;

namespace MotorcycleService.Controllers
{
    public class MotorcycleController : ApiController
    {
        [HttpGet]
        [Route("api/motorcycles")]
        public IHttpActionResult GetMotorcycles()
        {
            return Ok(MotorcycleDataSeedUtil.GetMotorcycles());
        }
    }
}