using Cinema.Entity.Abstract;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class Theater:EntityBaseIsActive,IEntity
    {
        public Theater()
        {
            Sessions = new HashSet<Session>();
            Seats = new HashSet<Seat>();
        }
        public string TheaterName { get; set; }


        public virtual ICollection<Seat> Seats { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }

    }
}
