using System;
using TicketsApp.Core.Interfaces;

namespace TicketsApp.Core.Models
{
    public class Ticket : BaseEntity
    {
        public string Name {get; set;}
        public string Description {get; set;}
        public DateTime ReturnDate {get; set;}
        public Event Event {get; set;}
    }
}
