using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.Entity.Concrete
{
    public class Log
    {
        public int Id { get; set; }
        public string TabloType { get; set; }
        public string Process { get; set; }
        public string OldData { get; set; }
        public string NewData { get; set; }
        public DateTime DateTime { get; set; }
        public Guid UserId { get; set; }
    }
}
