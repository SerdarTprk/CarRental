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

    
    public class ModelController
    {
        
        public ModelController()
        {
           
        }
        public List<ModelDTO> ModelList(Guid Id)
        {
            var model = Singleton.Uow.GetRepository<Model>().Get(m => m.IsActive == true && m.IsDeleted == false && m.BrandId == Id);
            List<ModelDTO> mdto = new List<ModelDTO>(9);
           
            foreach (var item in model)
            {
                ModelDTO dto = new ModelDTO()
                {
                    Id = item.Id,
                    ModelName = item.ModelName,
                    ModelYear = item.ModelYear,
                };
                mdto.Add(dto);
            }
            return mdto;
        }
        public ServiceResult ModelAdd(ModelDTO dto)
        {
            Model model = new Model();
            DTOtoModel(dto, model);
            ServiceResult result;
            try
            {
                
                var user = Singleton.Uow.GetRepository<Model>().Add(model);
                if (user == true)
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

                result = new ServiceResult("Hata gerçekleşti", ResultState.Error);
            }

            return result;
        }

       

        public void DTOtoModel(ModelDTO dto, Model model)
        {
            model.Id = Guid.NewGuid();
            model.ModelName = dto.ModelName;
            model.ModelYear = dto.ModelYear;
            model.UpdatedDate = DateTime.Today;
            model.UpdatedUser = Session.CurrentUser.Id;
            model.CreatedDate = DateTime.Today;
            model.CreatedUser = Session.CurrentUser.Id;
            model.BrandId = dto.BrandId;

        }
        public ServiceResult DeleteModel(ModelDTO dto)
        {
            var model = Singleton.Uow.GetRepository<Model>().Get(dto.Id);
            model.IsDeleted = true;
            try
            {
                if (Singleton.Uow.GetRepository<Model>().Update(model))
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
