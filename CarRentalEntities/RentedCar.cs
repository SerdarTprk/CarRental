using Framework.Core.DAL;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalEntities
{
   public class RentedCar : EntityBase, IEntity
    {
        public Guid CarId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? DeliveredDate { get; set; }
        public DateTime RentEndDate { get; set; }
        public bool RentCanceled { get; set; }
        public string Description { get; set; }
        public DateTime RentStartDate { get; set; }
        public int TankBefore { get; set; }
        public int TankAfter { get; set; }
        public int OdoMeterBefore { get; set; }
        public int OdoMeterAfter { get; set; }
        public int? LessorUser { get; set; }
        public int DailyPrice { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Car Car { get; set; }
    }
}
