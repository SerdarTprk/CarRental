using Framework.Core.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Abstract.IRepositoryBases
{
    public interface IUpdate<TEntity>
            where TEntity : IEntity
    {
        bool Update(TEntity entity);
    }
}
