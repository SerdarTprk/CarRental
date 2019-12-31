using CarRental.DAL.Abstract;
using CarRental.DAL.Abstract.IRepositoryBases;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL
{
    public class UnitOfWork:IUnitOfWork
    {
        DbContext _db;
        DbContextTransaction _transaction;
        public UnitOfWork()
        {
            _db = new CarRentalDbContext();
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
        public void RollBack()
        {
           _transaction.Rollback();
        }

        IRepository<T> IUnitOfWork.GetRepository<T>() 
        {
            return new Repository<T>(_db);
        }
    }
}
