using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DTO
{
    public  class CarListFilter
    {
        public bool AllCar { get; set; }
        public bool Rented { get; set; }
        public bool Deleted { get; set; }
    }
}
