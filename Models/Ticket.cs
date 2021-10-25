using System;

namespace TicketsApp.Client.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string Name {get; set;}
        public string Description {get; set;}
        public DateTime ReturnDate {get; set;}
        public Event Event {get; set;}
    }
}
