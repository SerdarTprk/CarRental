using CarRental.DAL.Abstract.IRepositoryBases;
using Framework.Core.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Abstract
{
    public interface IUnitOfWork : IDisposable
    {
        void BeginTran();
        void RollBack();
        void Commit();
        IRepository<T> GetRepository<T>() where T:class,IEntity;
    }
}
