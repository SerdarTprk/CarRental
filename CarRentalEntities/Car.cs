using CarRentalEnums;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class Car:EntityBase,IEntity
    {
        public Car()
        {
            RentedCar = new HashSet<RentedCar>();
            IsRented = false;
        }
        public string DailyPrice { get; set; }
        public DateTime InsuranceExpiryDate { get; set; }
        public DateTime InspectionExpiryDate { get; set; }
        public FuelTypeEnum FuelType { get; set; }
        public CarClassEnum CarClassEnum { get; set; }
        public string Plate { get; set; }
        public string CylindeerVolume { get; set; }
        public string EngineCapacity { get; set; }
        public CarColorEnum CarColorEnum { get; set; }
        public DriverLicenceTypeEnum DriverLicenceType { get; set; }
        public DateTime DateOfPurchase { get; set; }
        public bool IsRented { get; set; }
        public Guid ModelId { get; set; }
        public virtual Model Model { get; set; }
        public virtual ICollection<RentedCar> RentedCar { get; set; }
    }
}
