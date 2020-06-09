using Cinema.DAL.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL
{
    public class Singleton
    {
        private static IUnitOfWork _uow;
        public static IUnitOfWork Uow
        {
            get
            {
                if (_uow == null)
                {
                    return _uow = new UnitOfWork();
                }
                return _uow;
            }
        }
    }
}
