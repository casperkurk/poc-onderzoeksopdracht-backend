using System.Web.Http;
using CarService.Util;

namespace CarService.Controllers
{
    public class CarController : ApiController
    {
        [HttpGet]
        [Route("api/cars")]
        public IHttpActionResult GetCars()
        {
            return Ok(CarDataSeedUtil.GetMotorcycles());
        }
    }
}