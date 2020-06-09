using Cinema.Entity.Abstract;
using Cinema.Enums;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class Seat:EntityBaseIsActive,IEntity
    {
        
        public Seat()
        {
            SeatSales = new HashSet<SeatSale>();
        }
        public SeatTypeEnum SeatTypeNo { get; set; }
        public int SeatNo { get; set; }
        public Guid TheaterId { get; set; }


        public virtual ICollection<SeatSale> SeatSales { get; set; }
        public virtual Theater Theater { get; set; }

    }
}
