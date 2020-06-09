using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DTO
{
    public class RoleDTO
    {
        public RoleDTO()
        {
            Users = new List<UserDTO>();
        }
        public Guid Id { get; set; }
        public string RoleName { get; set; }

        public List<UserDTO> Users { get; set; }
    }
}
