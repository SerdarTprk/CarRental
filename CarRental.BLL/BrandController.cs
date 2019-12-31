using CarRental.DAL;
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
    public class BrandController
    {
        
        public ServiceResult AddBrand(BrandDTO dto)
        {

            Brand brand = new Brand()
            {
                BrandName = dto.BrandName,
                Id = Guid.NewGuid(),
                CreatedDate = DateTime.Today,
                CreatedUser = Session.CurrentUser.Id,
                UpdatedUser = Session.CurrentUser.Id,
                
            };
            ServiceResult result;
            try
            {
                bool islemYapildiMi = Singleton.Uow.GetRepository<Brand>().Add(brand); ;
                if (islemYapildiMi)
                {
                    result = new ServiceResult("İşlem başarılı", ResultState.Success);
                }
                else
                {
                    result = new ServiceResult("Yapılacak bir işlem kaydına rastlanmadı.", ResultState.Error);
                }
            }
            catch (Exception ex)
            {
                result = new ServiceResult("Hata: 4-34", ResultState.Error);
            }

            return result;
        }
        public List<BrandDTO> BrandListele()
        {
            List<BrandDTO> dto = new List<BrandDTO>();
            
            var brands = Singleton.Uow.GetRepository<Brand>().Get(b => b.IsActive == true && b.IsDeleted == false);
            foreach (Brand item in brands)
            {
                BrandDTO brand = new BrandDTO()
                {
                    Id = item.Id,
                    BrandName = item.BrandName,
                };
                dto.Add(brand);
            }
            return dto;
            
        }
        public ServiceResult DeleteBrand(BrandDTO dto)
        {
            var brand = Singleton.Uow.GetRepository<Brand>().Get(dto.Id);
            brand.IsDeleted = true;
            try
            {
                if (Singleton.Uow.GetRepository<Brand>().Update(brand))
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
