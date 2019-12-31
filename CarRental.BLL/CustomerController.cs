using CarRental.DAL;
using CarRental.DAL.Abstract;
using CarRental.DTO;
using CarRentalEntities;
using Framework.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.BLL
{
    public class CustomerController
    {

        public CustomerController()
        {

        }
        
        public List<CustomerDTO> GetAllCustomer()
        {
            var customers = Singleton.Uow.GetRepository<Customer>().Get(c => c.IsDeleted == false && c.IsActive == true);
            List<CustomerDTO> dtos = new List<CustomerDTO>();
            foreach (var item in customers)
            {
                CustomerDTO dto = new CustomerDTO()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Phone = item.Phone,
                    E_mail = item.E_mail,
                    Adress = item.Adress,
                    TcNo = item.TcNo,
                    DriverLicenceType = item.DriverLicenceType

                };
                dtos.Add(dto);
            }

            return dtos;
           
        }
        
        public ServiceResult CustomerAdd(CustomerDTO dto)
        {
            Customer customer = new Customer()
            {
                Id = Guid.NewGuid(),
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Phone = dto.Phone,
                E_mail = dto.E_mail,
                TcNo = dto.TcNo,
                Adress = dto.Adress,
                DriverLicenceType = dto.DriverLicenceType,
                UpdatedUser = Session.CurrentUser.Id,
                CreatedUser = Session.CurrentUser.Id,
                CreatedDate = DateTime.Today,
                UpdatedDate = DateTime.Today
                
            };
            ServiceResult result;
            try
            {
                bool islemYapildiMi = Singleton.Uow.GetRepository<Customer>().Add(customer);
                if (islemYapildiMi)
                {
                    result = new ServiceResult("İslem basarili", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Yapılacak bir islem kaydına rastlanamadı.", ResultState.Danger);
                }
            }
            catch (Exception ex)
            {

                result = new ServiceResult("Hata:CarController-35", ResultState.Error);
            }
            return result;
        }
        private void DtoToCustomer(CustomerDTO dto, Customer customer)
        {
            customer.FirstName = dto.FirstName;
            customer.LastName = dto.LastName;
            customer.TcNo = dto.TcNo;
            customer.Phone = dto.Phone;
            customer.Adress = dto.Adress;
            customer.E_mail = dto.E_mail;
            customer.DriverLicenceType = dto.DriverLicenceType;
        }
        private void CustomerToDto(Customer customer, CustomerDTO dto)
        {
            dto.Id = customer.Id;
            dto.FirstName = customer.FirstName;
            dto.E_mail = customer.E_mail;
            dto.DriverLicenceType = customer.DriverLicenceType;
            dto.Adress = customer.Adress;
            dto.LastName = customer.LastName;
            dto.Phone = customer.Phone;
        }
        /*
        public List<CustomerDTO> AllCustomers()
        {
            ICollection<Customer> customers = Singleton.Uow.GetRepository<Customer>().Get(c => c.IsDeleted == false || c.IsActive == true);
            return CustomerToDto(customers);
        }
        */
        private List<CustomerDTO> CustomerToDto(IEnumerable<Customer> customer)
        {

            List<CustomerDTO> result = new List<CustomerDTO>();
            foreach (var customers in customer)
            {
                CustomerDTO dto = new CustomerDTO();
                CustomerToDto(customers, dto);
                result.Add(dto);
            }
            return result;
        }
        public ServiceResult UpdateCustomer(CustomerDTO dto)
        {
            var customer = Singleton.Uow.GetRepository<Customer>().Get(dto.Id);
            DtoToCustomer(dto, customer);
            try
            {
                if (Singleton.Uow.GetRepository<Customer>().Update(customer))
                {
                    return new ServiceResult("Güncelleme başarılı", ResultState.Success);
                }
                else
                {
                    return new ServiceResult("Herhangi değişiklik yapılmamıştır", ResultState.Danger);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public ServiceResult CustomerDelete(CustomerDTO dto)
        {
            var customer = Singleton.Uow.GetRepository<Customer>().Get(dto.Id);
            customer.IsDeleted = true;
            try
            {
                if (Singleton.Uow.GetRepository<Customer>().Update(customer))
                {
                    return new ServiceResult("Silme işlemi başarılıdır.", ResultState.Success);
                }
                else
                {
                    return new ServiceResult("İşlem yapılacak kayıt bulunamamıştır.", ResultState.Error);
                }

            }
            catch (Exception)
            {

                return new ServiceResult("Hata", ResultState.Error);
            }
        }
    }
}
