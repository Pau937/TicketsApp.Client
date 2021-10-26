using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketsApp.API.Dtos.Tickets;
using TicketsApp.Core.Services.Interfaces;

namespace TicketsApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            var tickets = _ticketService.GetAll();

            var result = tickets.Select(ticket => new TicketDto{
                Id = ticket.Id,
                Name = ticket.Name
            });

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTicket(int id)
        {
            var result = await _ticketService.GetByIdAsync(id);

            return Ok(result);
        }

        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        private readonly ITicketService _ticketService;
    }
}
