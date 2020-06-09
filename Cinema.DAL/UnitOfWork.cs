using Cinema.DAL.Abstract;
using Cinema.DAL.Abstract.IRepositoryBases;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        DbContext _db;
        DbContextTransaction _transaction;
        public UnitOfWork()
        {
            _db = new CinemaDbContext();
        }
        public void BeginTran()
        {
            _transaction = _db.Database.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Dispose()
        {
            _db.Dispose();
            _transaction.Dispose();
            _transaction = null;
            _db = null;
        }
        public void Rollback()
        {
            _transaction.Rollback();
        }
        IRepository<TEntity> IUnitOfWork.GetRepository<TEntity>()
        {
            return new Repository<TEntity>(_db);
        }


    }
}
