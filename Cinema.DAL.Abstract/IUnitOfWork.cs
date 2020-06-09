using Cinema.DAL.Abstract.IRepositoryBases;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        void BeginTran();
        void Rollback();
        void Commit();
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class, IEntity;
    }
}
