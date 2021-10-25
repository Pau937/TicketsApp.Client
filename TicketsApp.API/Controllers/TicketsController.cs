using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TicketsApp.API.Dtos.Tickets;
using TicketsApp.Core.Services.Interfaces;

namespace TicketsApp.Client.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllTickets()
        {
            var tickets = _ticketService.GetAllTickets();

            var result = tickets.Select(ticket => new TicketDto{
                Id = ticket.Id,
                Name = ticket.Name
            });

            return Ok(result);
        }

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        private readonly ITicketService _ticketService;
    }
}
