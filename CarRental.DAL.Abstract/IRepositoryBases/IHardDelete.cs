using Framework.Core.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Abstract.IRepositoryBases
{

    public interface IHardDelete<TEntity>
        where TEntity : IEntity
    {
        bool HardDelete(TEntity entity);
        bool HardDelete(Guid id);
    }

}
