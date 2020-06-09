using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTO
{
    public class SeatSaleDTO
    {
        public Guid Id { get; set; }
        public Guid SessionId { get; set; }
        public Guid SeatId { get; set; }
        public decimal Price { get; set; }

        public SeatDTO Seat { get; set; }
        public SessionDTO Session { get; set; }
        public TicketDTO Ticket { get; set; }
    }
}
