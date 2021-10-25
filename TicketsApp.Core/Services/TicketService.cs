using System.Collections.Generic;
using System.Threading.Tasks;
using TicketsApp.Core.Interfaces;
using TicketsApp.Core.Models;
using TicketsApp.Core.Services.Interfaces;

namespace TicketsApp.Core.Services
{
    public class TicketService : ITicketService
    {
        public IEnumerable<Ticket> GetAllTickets()
        {
            return new List<Ticket>
            {
                new Ticket
                {
                    Id = 1,
                    Name = "Test",
                    Description = "Test description"
                },
                new Ticket
                {
                    Id = 2,
                    Name = "Test",
                    Description = "Test description"
                },
                new Ticket
                {
                    Id = 3,
                    Name = "Test",
                    Description = "Test description"
                }
            };
        }

        public async Task<Ticket> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public TicketService(IAsyncRepository<Ticket> repository)
        {
            _repository = repository;
        }

        private readonly IAsyncRepository<Ticket> _repository;
    }
}
