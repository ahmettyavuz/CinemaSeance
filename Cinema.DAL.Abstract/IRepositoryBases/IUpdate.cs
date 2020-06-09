using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Abstract.IRepositoryBases
{
    public interface IUpdate<TEntity> where TEntity:IEntity
    {
        TEntity Update(TEntity entity);
    }
}
