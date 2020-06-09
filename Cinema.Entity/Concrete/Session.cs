using Cinema.Entity.Abstract;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class Session:EntityBaseIsActive,IEntity
    {
        public Session()
        {
            SeatSales = new HashSet<SeatSale>();
            Tickets = new HashSet<Ticket>();

        }
        public Guid MovieId { get; set; }
        public Guid TheaterId { get; set; }
        public Guid SeanceId { get; set; }
        public DateTime ShowDate { get; set; }


        public virtual Seance Seance { get; set; }
        public virtual Theater Theater { get; set; }
        public virtual Movie Movie { get; set; }
        public virtual ICollection<SeatSale> SeatSales { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }

    }
}
