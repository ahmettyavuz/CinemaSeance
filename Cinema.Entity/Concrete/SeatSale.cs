using Cinema.Entity.Abstract;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class SeatSale:EntityBase,IEntity
    {
        public SeatSale()
        {

        }
        public Guid TicketId { get; set; }
        public Guid SessionId { get; set; }
        public Guid SeatId { get; set; }
        public decimal Price { get; set; }


        public virtual Seat Seat { get; set; }
        public virtual Session Session { get; set; }
        public virtual Ticket Tickets { get; set; } 
    }
}
