using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTO
{
    public class TheaterDTO
    {
        public TheaterDTO()
        {
            Sessions = new List<SessionDTO>();
            Seats = new List<SeatDTO>();
        }
        public Guid Id { get; set; }
        public string TheaterName { get; set; }

        public List<SeatDTO> Seats { get; set; }
        public List<SessionDTO> Sessions { get; set; }
    }
}
