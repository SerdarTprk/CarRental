using CarRental.DAL;
using CarRental.DTO;
using CarRentalEntities;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Framework.Linq;
using Framework.Core;

namespace CarRental.BLL
{
    public class CarController
    {
        public List<CarDTO> GetAllCar()
        {
            var cars = Singleton.Uow.GetRepository<Car>().Get(c=>c.IsDeleted==false&&c.IsActive==true);
            List<CarDTO> dtos = new List<CarDTO>();
            foreach (var item in cars)
            {
                CarDTO dto = new CarDTO()
                {
                    Id = item.Id,
                    Plate = item.Plate,
                    IsRented = item.IsRented,
                    CylindeerVolume = item.CylindeerVolume,
                    DailyPrice = item.DailyPrice,
                    DateOfPurchase = item.DateOfPurchase,
                    EngineCapacity = item.EngineCapacity,
                    InspectionExpiryDate = item.InspectionExpiryDate,
                    InsuranceExpiryDate = item.InsuranceExpiryDate,
                    CarClassEnum = item.CarClassEnum,
                    CarColorEnum = item.CarColorEnum,
                    FuelType = item.FuelType,
                    DriverLicenceType = item.DriverLicenceType,
                    IsActive=item.IsActive,
                    

                };
                dtos.Add(dto);
            }

            return dtos;
        }
        public List<CarDTO> GetAllCar(CarListFilter filter)
        {

            Expression<Func<Car, bool>> exp = x => true;



            if (filter.AllCar)
            {
                exp= x=> true;
            }
            else if (filter.Rented==true )
            {
                exp.And(x => x.IsRented == true&&x.IsActive==true);
            }
            else if (filter.Deleted==true)
            {
                exp.And(x => x.IsDeleted == true);
            }
            
            List<CarDTO> dtos = new List<CarDTO>();
            var cars = Singleton.Uow.GetRepository<Car>().Get(exp);
            foreach (var item in cars)
            {
                CarDTO dto = new CarDTO()
                {
                    Id = item.Id,
                    Plate = item.Plate,
                    IsRented = item.IsRented,
                    CylindeerVolume = item.CylindeerVolume,
                    DailyPrice = item.DailyPrice,
                    DateOfPurchase = item.DateOfPurchase,
                    EngineCapacity = item.EngineCapacity,
                    InspectionExpiryDate = item.InspectionExpiryDate,
                    InsuranceExpiryDate = item.InsuranceExpiryDate,
                    CarClassEnum = item.CarClassEnum,
                    CarColorEnum = item.CarColorEnum,
                    FuelType = item.FuelType,
                    DriverLicenceType = item.DriverLicenceType,
                    IsActive = item.IsActive

                };
                dtos.Add(dto);
            }

            return dtos;
        }

        public ServiceResult CarUpdate(CarDTO dto)
        {
            var car = Singleton.Uow.GetRepository<Car>().Get(dto.Id);
            DtoToCar(dto, car);
            try
            {
                if (Singleton.Uow.GetRepository<Car>().Update(car))
                {
                    return new ServiceResult("güncelleme başarılı", ResultState.Success);
                }
                else
                {
                    return new ServiceResult("herhangi bir değişiklik yapılmamıştır", ResultState.Danger);

                }
            }
            catch (Exception)
            {

                return new ServiceResult("hAta meydana geldi", ResultState.Error);
            }
        }

        private void DtoToCar(CarDTO dto, Car car)
        {
            car.CylindeerVolume = dto.CylindeerVolume;
            car.DailyPrice = dto.DailyPrice;
            car.EngineCapacity = dto.EngineCapacity;
            car.FuelType = dto.FuelType;
            car.DateOfPurchase = dto.DateOfPurchase;
            car.InspectionExpiryDate = dto.InspectionExpiryDate;
            car.InsuranceExpiryDate = dto.InsuranceExpiryDate;
            car.Plate = dto.Plate;
            car.CarClassEnum = dto.CarClassEnum;
            car.CarColorEnum = dto.CarColorEnum;
            car.DriverLicenceType = dto.DriverLicenceType;
            car.IsActive = dto.IsActive;
            car.UpdatedUser = Session.CurrentUser.Id;
            car.UpdatedDate = DateTime.Today;
            
        }
     
        public ServiceResult CarAdd(CarDTO dto)
        {
            Car car = new Car()
            {
                Id = Guid.NewGuid(),
                Plate = dto.Plate,
                CarClassEnum = dto.CarClassEnum,
                EngineCapacity = dto.EngineCapacity,
                CylindeerVolume = dto.CylindeerVolume,
                DailyPrice = dto.DailyPrice,
                DriverLicenceType = dto.DriverLicenceType,
                InsuranceExpiryDate = dto.InsuranceExpiryDate,
                InspectionExpiryDate = dto.InspectionExpiryDate,
                CarColorEnum = dto.CarColorEnum,
                DateOfPurchase = dto.DateOfPurchase,
                UpdatedUser = Session.CurrentUser.Id,
                CreatedUser = Session.CurrentUser.Id,
                CreatedDate = DateTime.Today,
                UpdatedDate = DateTime.Today,
                IsRented=dto.IsRented,
                FuelType=dto.FuelType,
                ModelId=dto.ModelId
                
            };
            ServiceResult result;
            try
            {
                bool islemYapildiMi = Singleton.Uow.GetRepository<Car>().Add(car);
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
        public ServiceResult DeleteCar(CarDTO dto)
        {
            var car = Singleton.Uow.GetRepository<Car>().Get(dto.Id);
            car.IsDeleted = true;
            try
            {
                if (Singleton.Uow.GetRepository<Car>().Update(car))
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
