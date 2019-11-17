using System.Web.Http;
using Ticketing.Web.Models;

namespace Ticketing.Web.Controllers.Api
{
    public class TicketsApiController : ApiController
    {
        [HttpPost]
        [Route("api/tickets")]
        public IHttpActionResult Create(TicketCreateCommand command)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);

            command.Execute();

            return Ok();
        }
    }

    public class TicketCreateCommand : TicketCreateDTO
    {
        private readonly ITicketRepository _ticketRepository;

        public TicketCreateCommand() : this (new TicketRepository())
        {

        }

        public TicketCreateCommand(ITicketRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public Ticket Execute()
        {
            var ticket = new Ticket();
            _ticketRepository.Save(ticket);
            return ticket;
        }
    }

    public interface ITicketRepository
    {
        void Save(Ticket ticket);
    }

    public class TicketRepository : ITicketRepository
    {
        public void Save(Ticket ticket)
        {
            ticket.Id = 1;
        }
    }
}

