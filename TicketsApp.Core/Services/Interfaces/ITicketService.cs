using System.Collections.Generic;
using TicketsApp.Core.Models;

namespace TicketsApp.Core.Services.Interfaces
{
    public interface ITicketService
    {
        IEnumerable<Ticket> GetAllTickets();
    }
}