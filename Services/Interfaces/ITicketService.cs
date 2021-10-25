using System.Collections.Generic;
using TicketsApp.Client.Models;

namespace TicketsApp.Client.Services.Interfaces
{
    public interface ITicketService
    {
        IEnumerable<Ticket> GetAllTickets();
    }
}