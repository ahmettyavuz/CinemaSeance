using Cinema.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTO
{
    public class SeatDTO
    {
        public SeatDTO()
        {
            SeatSales = new List<SeatSaleDTO>();
        }
        public Guid Id { get; set; }
        public SeatTypeEnum SeatType { get; set; }
        public int SeatNo { get; set; }
        public Guid TheaterId { get; set; }


        public List<SeatSaleDTO> SeatSales { get; set; }
        public TheaterDTO Theater { get; set; }
    }
}
