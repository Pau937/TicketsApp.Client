using System.Collections.Generic;
using System.Threading.Tasks;
using TicketsApp.Core.Models;

namespace TicketsApp.Core.Services.Interfaces
{
    public interface ITicketService
    {
        IEnumerable<Ticket> GetAll();
        Task<Ticket> GetByIdAsync(int id);
    }
}
