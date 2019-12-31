using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DTO
{
   public class RoleDTO
    {
        public RoleDTO()
        {
            Users = new HashSet<UserDTO>();
        }
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public virtual ICollection<UserDTO> Users { get; set; }
    }
}
