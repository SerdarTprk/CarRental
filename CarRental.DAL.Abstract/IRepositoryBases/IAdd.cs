using Framework.Core.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Abstract.IRepositoryBases
{
    public interface IAdd<TEntity>
        where TEntity:IEntity
    {
        bool Add(TEntity entity);
    }
}
