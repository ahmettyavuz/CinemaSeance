using Cinema.Entity.Abstract;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class Role:EntityBaseIsActive,IEntity
    {
        public Role()
        {
            Users = new HashSet<User>();
        }
        public string RoleName { get; set; }


        public virtual ICollection<User> Users { get; set; }

    }
}
