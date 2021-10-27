using System.Collections.Generic;
using System.Threading.Tasks;
using TicketsApp.Core.Models;

namespace TicketsApp.Core.Services.Interfaces
{
    public interface ITicketService
    {
        Task<IEnumerable<Ticket>> GetAllAsync();
        Task<Ticket> GetByIdAsync(int id);
    }
}
