using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTO
{
    public class SessionDTO
    {
        public SessionDTO()
        {
            SeatSales = new List<SeatSaleDTO>();
        }
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Guid TheaterId { get; set; }
        public Guid SeanceId { get; set; }
        public DateTime ShowDate { get; set; }

        public SeanceDTO Seance { get; set; }
        public TheaterDTO Theater { get; set; }
        public MovieDTO Movie { get; set; }
        public List<SeatSaleDTO> SeatSales { get; set; }
    }
}
