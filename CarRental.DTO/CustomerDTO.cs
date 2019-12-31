using CarRentalEnums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DTO
{
   public class CustomerDTO
    {
        public CustomerDTO()
        {
            RentedCars = new HashSet<RentedCarDTO>();
        }
        public Guid Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Adress { get; set; }

        public string E_mail { get; set; }

        public DriverLicenceTypeEnum DriverLicenceType { get; set; }

        public string TcNo { get; set; }

        public virtual ICollection<RentedCarDTO> RentedCars { get; set; }
    }
}
