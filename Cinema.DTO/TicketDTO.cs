using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTO
{
    public class TicketDTO
    {
        public TicketDTO()
        {
            SeatSales = new List<SeatSaleDTO>();
        }
        public Guid Id { get; set; }
        public Guid SalesId { get; set; }
        public decimal Cost { get; set; }
        public DateTime Date { get; set; }

        public List<SeatSaleDTO> SeatSales { get; set; }
    }
}
