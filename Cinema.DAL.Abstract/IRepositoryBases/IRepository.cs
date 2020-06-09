using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Abstract.IRepositoryBases
{
    public interface IRepository<TEntity>:IAdd<TEntity>,IGet<TEntity>,IUpdate<TEntity> where TEntity:IEntity
    {

    }
}
