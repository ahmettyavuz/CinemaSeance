using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTO
{
    public class DirectorDTO
    {
        public DirectorDTO()
        {
            Movies = new List<MovieDTO>();
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return FirstName + " " + LastName; } }

        public List<MovieDTO> Movies { get; set; }
    }
}
