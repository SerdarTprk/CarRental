using CarRental.DAL;
using CarRental.DTO;
using CarRentalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Core;


namespace CarRental.BLL
{
    public class UserController
    {
       
        RoleDTO rdto = new RoleDTO();
        UserDTO dto = new UserDTO();
        public UserController()
        {
            
        }
        public List<UserDTO> UserList()
        {
            var user = Singleton.Uow.GetRepository<User>().Get(u => u.IsActive == true && u.IsDeleted==false);
            List<UserDTO> dto = new List<UserDTO>();

            foreach (var item in user)
            {
                UserDTO udto = new UserDTO()
                {
                    Id = item.Id,
                    UserName = item.UserName,
                    Password = item.Password,

                };
                dto.Add(udto);
            }
            return dto;
        }
        public UserDTO UserLogin(string userName, string password)
        {

            var user = Singleton.Uow.GetRepository<User>().Get(u => u.UserName == userName && u.Password == password && u.IsActive==true &&u.IsDeleted==false);
          
            if (user !=null)
            {
                foreach (var item in user)
                {
                    dto = new UserDTO()
                    {
                        Id = item.Id,
                        UserName=item.UserName,
                        Password=item.Password,

                    };

                    HashSet<Role> role  = (HashSet<Role>)item.Role;

                    foreach (var roles in role)
                    {
                        rdto = new RoleDTO()
                        {
                            Id = roles.Id,
                            RoleName = roles.RoleName,

                        };
                        dto.Roles.Add(rdto);
                    }
                }

                return dto;
            }
            else
            {
                return null;
            }

        }
        public ServiceResult UserAdd(UserDTO dto,List<RoleDTO> rdto)
        {
            User user = new User()
            {
                UserName = dto.UserName,
                Password = dto.Password,
                Id = Guid.NewGuid(),
            };



            foreach (var item in rdto)
            {
                Role role = Singleton.Uow.GetRepository<Role>().Get(item.Id);


                user.Role.Add(role);

            }
            ServiceResult result;
            
                bool islem = Singleton.Uow.GetRepository<User>().Add(user);
            try
            {
                if (islem == true)
                {
                    result = new ServiceResult("İşlem başarılı", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("İşlem başarısız", ResultState.Danger);
                }

            }
            catch (Exception)
            {

                result = new ServiceResult("HATA meydana geldi", ResultState.Error);
            }
                
           
            return result;

        }
       

     
    }
}
