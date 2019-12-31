using CarRental.DAL;
using CarRental.DAL.Abstract;
using CarRental.DTO;
using CarRentalEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.BLL.Controllers
{

    public class CarControl
    {
        IUnitOfWork _uow;
        public CarControl()
        {
            _uow = Singleton.Uow;
        }
        public List<CarDTO> GetAllCar()
        {
            IEnumerable<Car> cars = _uow.GetRepository<Car>().Get(p => p.IsDeleted == false || p.IsDeleted == null);
            return CarToDto(cars);
        }
        private void DtoToCar(CarDTO dto, Car Car)
        {
            Car.Id = dto.Id;
            
        }
        private void CarToDto(Car Car, CarDTO dto)
        {
            dto.Id = Car.Id;
            
        }
        private List<CarDTO> CarToDto(IEnumerable<Car> Cars)
        {
            List<CarDTO> result = new List<CarDTO>();

            foreach (var Car in Cars)
            {
                CarDTO dto = new CarDTO();
                CarToDto(Car, dto);
                result.Add(dto);
            }
            return result;
        }
    }
}
