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
    public class Movie:EntityBaseIsActive,IEntity
    {
        public Movie()
        {
            Casts = new HashSet<Cast>();
            Directors = new HashSet<Director>();
            Sessions = new HashSet<Session>();

        }
        public string MovieName { get; set; }
        public MovieTypeEnum MovieTypeNo { get; set; }
        public int MovieTime { get; set; }
        public bool TD { get; set; }
        public int Year { get; set; }


        public virtual ICollection<Cast> Casts { get; set; }
        public virtual ICollection<Director> Directors { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }


    }
}
