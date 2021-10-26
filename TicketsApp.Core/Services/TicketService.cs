using System.Collections.Generic;
using System.Threading.Tasks;
using TicketsApp.Core.Interfaces;
using TicketsApp.Core.Models;
using TicketsApp.Core.Services.Interfaces;

namespace TicketsApp.Core.Services
{
    public class TicketService : ITicketService
    {
        public IEnumerable<Ticket> GetAll()
        {
            return _repository.GetAll();
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
