using CarRentalEnums;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class Role :  IEntity
    {
        public Role()
        {
            User = new HashSet<User>();
        }
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<User> User { get; set; }
    }

}
