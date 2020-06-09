using Cinema.DAL.Abstract.IRepositoryBases;
using Cinema.Entity.Concrete;
using Framework.Core.DAL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Cinema.DAL
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity:class,IEntity
    {
        DbContext _db;
        public Repository(DbContext db)
        {
            _db = db;
        }
        public TEntity Add(TEntity entity)
        {
            _db.Set<TEntity>().Add(entity);
            int ess = _db.SaveChanges();
            if (ess > 0)
            {
                return entity;
            }
            return null;
            
        }

        public ICollection<TEntity> Get(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                filter = x => true;
            }
            return _db.Set<TEntity>().Where(filter).ToList();
        }
        public TEntity GetSpesific(Expression<Func<TEntity, bool>> filter = null)
        {
            if (filter == null)
            {
                filter = x => false;
            }
            return _db.Set<TEntity>().Where(filter).SingleOrDefault();

        }

        public TEntity Get(Guid Id)
        {
            return _db.Set<TEntity>().Find(Id);
        }

        public TEntity Update(TEntity entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            int ess = _db.SaveChanges();
            if (ess > 0)
            {
                return entity;
            }
            return null;

        }
    }
}
