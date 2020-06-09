using Cinema.Entity.Abstract;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class User:EntityBaseIsActive,IEntity
    {
        public User()
        {
            Roles = new HashSet<Role>();
        }
        public string UserName { get; set; }
        public string Password { get; set; }


        public virtual ICollection<Role> Roles { get; set; }

    }
}
