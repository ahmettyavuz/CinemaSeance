using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTO
{
    public class UserDTO
    {
        public UserDTO()
        {
            Roles = new List<RoleDTO>();
        }
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public List<RoleDTO> Roles { get; set; }
    }
}
