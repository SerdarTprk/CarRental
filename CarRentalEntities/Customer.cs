using CarRentalEnums;
using Framework.Core.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
    public class Customer : EntityBase, IEntity
    {
        public Customer()
        {
            RentedCar = new HashSet<RentedCar>();
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Adress { get; set; }

        public string E_mail { get; set; }

        public DriverLicenceTypeEnum DriverLicenceType { get; set; }

        public string TcNo { get; set; }

        public virtual ICollection<RentedCar> RentedCar { get; set; }
    }
}
