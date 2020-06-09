using Cinema.Entity.Abstract;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class Ticket:EntityBaseIsActive,IEntity
    {
        public Ticket()
        {
            SeatSales = new HashSet<SeatSale>();
        }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }

        public ICollection<SeatSale> SeatSales { get; set; }

    }
}
