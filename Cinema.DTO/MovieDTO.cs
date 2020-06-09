using Cinema.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTO
{
    public class MovieDTO
    {
        public MovieDTO()
        {
            Casts = new List<CastDTO>();
            Directors = new List<DirectorDTO>();
            Sessions = new List<SessionDTO>();
        }
        public Guid Id { get; set; }
        public string MovieName { get; set; }
        public MovieTypeEnum MovieTypeNo { get; set; }
        public int MovieTime { get; set; }
        public bool TD { get; set; }
        public int Year { get; set; }

        public List<CastDTO> Casts { get; set; }
        public List<DirectorDTO> Directors { get; set; }
        public List<SessionDTO> Sessions { get; set; }
    }
}
