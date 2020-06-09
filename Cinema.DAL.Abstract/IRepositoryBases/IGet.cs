using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Abstract.IRepositoryBases
{
    public interface IGet<TEntity> where TEntity:IEntity
    {
        ICollection<TEntity> Get(Expression<Func<TEntity, bool>> filter = null);
        TEntity Get(Guid Id);
        TEntity GetSpesific(Expression<Func<TEntity, bool>> filter = null);
    }
}
