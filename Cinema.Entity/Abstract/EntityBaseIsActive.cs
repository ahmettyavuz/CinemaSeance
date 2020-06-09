using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Abstract
{
    public abstract class EntityBaseIsActive:EntityBase
    {
        public bool IsActive { get; set; }
    }
}
