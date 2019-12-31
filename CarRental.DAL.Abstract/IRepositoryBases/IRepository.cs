using Framework.Core.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Abstract.IRepositoryBases
{
    public interface IRepository<TEntity> : IAdd<TEntity>, IGet<TEntity>, IUpdate<TEntity>, IHardDelete<TEntity>
            where TEntity : IEntity

    {
        public IQueryable<TEntity> GetQuery();
    }
}
