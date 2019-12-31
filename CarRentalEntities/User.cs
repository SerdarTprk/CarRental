using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class User : IEntity
    {
        public User()
        {
            Role = new HashSet<Role>();
            IsDeleted = false;
            IsActive = true;
        }
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Role> Role { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public DateTime? UpDatedDate { get; set; }
        public int MyProperty { get; set; }
    }
}
