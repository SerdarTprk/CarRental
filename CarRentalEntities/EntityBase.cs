using Framework.Core.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class EntityBase:IEntity
    {
        public EntityBase()
        {
            IsDeleted = false;
            IsActive = true;
        }
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public Guid CreatedUser { get; set; }
        public Guid UpdatedUser { get; set; }
    }
}
