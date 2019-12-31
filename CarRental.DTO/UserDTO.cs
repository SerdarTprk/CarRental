using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DTO
{
  public  class UserDTO
    {
        public UserDTO()
        {
            Roles = new HashSet<RoleDTO>();
        }
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<RoleDTO> Roles { get; set; }
    }
}
