using CarRentalEntities;
using CarRentalEnums;
using System;
using System.Collections.Generic;

namespace CarRental.DTO
{
    public  class CarDTO
    {

        public CarDTO()
        {
            RentedCars = new HashSet<RentedCarDTO>();
            
        }
        public Guid Id { get; set; }
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
        public bool IsActive  { get; set; }
        public bool IsDeleted { get; set; }
        public virtual Model Model { get; set; }
        public virtual ICollection<RentedCarDTO> RentedCars { get; set; }


    }
}
