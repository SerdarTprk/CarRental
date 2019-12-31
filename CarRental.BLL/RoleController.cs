using CarRental.DAL;
using CarRental.DTO;
using CarRentalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.BLL
{
    public class RoleController
    {
        public List<RoleDTO> RoleList()
        {
            var role = Singleton.Uow.GetRepository<Role>().Get();

            List<RoleDTO> result = new List<RoleDTO>();

            

            foreach (var item in role)
            {
                RoleDTO dto = new RoleDTO()
                {
                    Id = item.Id,
                    RoleName = item.RoleName,
                };
                result.Add(dto);
            }
            return result;
        }

      
    }
}
