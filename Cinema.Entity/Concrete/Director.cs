using Cinema.Entity.Abstract;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class Director:EntityBaseIsActive,IEntity
    {
        public Director()
        {
            Movies = new HashSet<Movie>();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }

    }
}
