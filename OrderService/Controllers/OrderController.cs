using System.Web.Http;
using OrderService.Models;

namespace OrderService.Controllers
{
    public class OrderController : ApiController
    {
        [HttpPost]
        [Route("api/placeorder")]
        public IHttpActionResult PlaceOrder([FromBody] Order order)
        {
            return Ok(order.Vehicle);
        }
    }
}