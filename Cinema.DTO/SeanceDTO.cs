using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTO
{
    public class SeanceDTO
    {
        public SeanceDTO()
        {
            Sessions = new List<SessionDTO>();
        }
        public Guid Id { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan FinishTime { get; set; }

        public string SeanceInformation { get { return "Bas:"+StartTime + "     Bit:" + FinishTime; } }
        public List<SessionDTO> Sessions { get; set; }
    }
}
