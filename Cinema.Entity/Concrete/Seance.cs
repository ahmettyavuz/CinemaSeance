using Cinema.Entity.Abstract;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class Seance:EntityBaseIsActive,IEntity
    {
        public Seance()
        {
            Sessions = new HashSet<Session>();
        }
        public TimeSpan StartTime { get; set; }
        public TimeSpan FinishTime { get; set; }


        public virtual ICollection<Session> Sessions { get; set; }

    }
}
