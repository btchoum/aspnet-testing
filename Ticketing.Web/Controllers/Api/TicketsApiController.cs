using System.Web.Http;
using Ticketing.Web.Models;

namespace Ticketing.Web.Controllers.Api
{
    public class TicketsApiController : ApiController
    {
        [HttpPost]
        [Route("api/tickets")]
        public IHttpActionResult Create(TicketCreateDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            return Ok();
        }
    }
}

