using CarRental.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.BLL
{
    public class Session
    {
        public static UserDTO CurrentUser { get; set; }
        public static RoleDTO CurrentRole { get; set; }

    }
}
